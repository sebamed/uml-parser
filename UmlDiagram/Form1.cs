using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDiagram.model;
using UmlDiagram.model.addons;
using UmlDiagram.model.connections;
using UmlDiagram.model.connections.types;

namespace UmlDiagram
{
    public partial class UmlParser : Form
    {

        private List<Rectangle> listDrawnClasses;
        private List<MaxApstractionClass> listMaxApstractionClass;
        private List<MaxApstractionClass> listSelectedMaxApstractionClass;

        private Connection selectedConnection;

        private List<Connection> listOfConnections;

        private Graphics g;

        public UmlParser()
        {
            this.listDrawnClasses = new List<Rectangle>();
            this.listMaxApstractionClass = new List<MaxApstractionClass>();
            this.listSelectedMaxApstractionClass = new List<MaxApstractionClass>();
            this.listOfConnections = new List<Connection>();
            this.selectedConnection = new Association();

            InitializeComponent();
            // components settings
            this.pnlRight.Enabled = false;
            this.tfClassName.Enabled = false;
            this.gbConnectionOptions.Enabled = false;
            this.cbAddPropertyAccessor.SelectedIndex = 0;
            this.cbAddMethodAccessor.SelectedIndex = 0;
            this.cbxConnectionType.SelectedIndex = 0;
            this.cbxConnCardFirst.SelectedIndex = 0;
            this.cbxConnCardSecond.SelectedIndex = 0;
            this.CenterToScreen();

            this.g = pnlDrawingBoard.CreateGraphics();
            this.pnlDrawingBoard.MouseClick += MouseClicked;
        }

        private void setConnectionInfo()
        {
            this.lblConnInfoTypeField.Text = this.selectedConnection.type;
            this.lblConnInfoTitleField.Text = this.selectedConnection.title;
            this.lblConnInfoCardinalityField.Text = this.selectedConnection.cFirst + "  -  " + this.selectedConnection.cSecond;
            this.lblConnInfoClassesField.Text = this.selectedConnection.fromClass.name + "  -  " + this.selectedConnection.toClass.name;
        }

        private void MouseClicked(object sender, MouseEventArgs e)
        {

            if (this.cbSelectConnection.Checked)
            {
                foreach(Connection c in this.listOfConnections)
                {
                    foreach(Line l in c.getConnectionLines())
                    {
                        if(l.contains(new Point(e.X, e.Y)))
                        {
                            this.selectedConnection = c;
                            this.setConnectionInfo();
                            return;
                        } 
                    }
                }
            }

            if(this.cbShowDetails.Checked)
            {
                MessageBox.Show("You are in edit mode, can't make or select new classes! Uncheck it first!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (this.rbClass.Checked)
            {
                if (this.tfClassName.Text == "")
                {
                    MessageBox.Show("Please fill in class name field!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (this.tfClassName.Text.Length > 13)
                {
                    MessageBox.Show("Class name can't be longer than 13 characters!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    this.tfClassName.Text = this.tfClassName.Text.Substring(0, 13);
                }
                else
                {
                    if (this.doesClassNameExist())
                    {
                        MessageBox.Show("Class with name " + this.tfClassName.Text.ToString() + " already exists!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        this.tfClassName.Focus();
                        return;
                    }
                    MaxApstractionClass mClass = new MaxApstractionClass(this.tfClassName.Text.ToString(), e.X, e.Y);
                    foreach (MaxApstractionClass mc in this.listMaxApstractionClass)
                    {
                        if (mc.classRec.Contains(e.X, e.Y))
                        {
                            mClass.classRec.X += mClass.classRec.Width + 5;
                            mClass.classRec.Y = mc.classRec.Y;
                            break;
                        }
                    }

                    mClass.draw(this.g);
                    this.listMaxApstractionClass.Add(mClass);
                }
            }
            else // selection mode is on
            {
                foreach (MaxApstractionClass mClass in this.listMaxApstractionClass)
                {
                    if (mClass.classRec.Contains(e.X, e.Y))
                    {
                        foreach (MaxApstractionClass selectedMClass in this.listSelectedMaxApstractionClass)
                        {
                            if (mClass == selectedMClass)
                            {
                                // deselect
                                mClass.defaultBrush = Brushes.LightGray;
                                mClass.defaultPen = Pens.Black;
                                mClass.defaultFontBrush = Brushes.Black;
                                mClass.draw(this.g);
                                this.listSelectedMaxApstractionClass.Remove(selectedMClass);
                                if(this.listSelectedMaxApstractionClass.Count < 2)
                                {
                                    this.gbConnectionOptions.Enabled = false;
                                }
                                return;
                            }
                        }

                        if(this.listSelectedMaxApstractionClass.Count > 1)
                        {
                            MessageBox.Show("You can't select more than 2 classes at the same time!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                        // select
                        mClass.defaultBrush = Brushes.DodgerBlue;
                        mClass.defaultPen = Pens.RoyalBlue;
                        mClass.defaultFontBrush = Brushes.White;
                        mClass.draw(this.g);
                        this.listSelectedMaxApstractionClass.Add(mClass);
                        if(listSelectedMaxApstractionClass.Count == 2)
                        {                     
                            this.gbConnectionOptions.Enabled = true;
                        }
                        return;

                    }
                }
            }
        }

        private bool doesClassNameExist()
        {
            foreach (MaxApstractionClass mClass in this.listMaxApstractionClass)
            {
                if (this.tfClassName.Text.ToString() == mClass.name)
                {
                    return true;
                }
            }
            return false;
        }

        private void cbShowDetails_CheckedChanged(object sender, EventArgs e)
        {
            if(this.listSelectedMaxApstractionClass.Count > 1) // more than 1 selected
            {
                MessageBox.Show("You can't select more than 1 class!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.cbShowDetails.Checked = false;
            } else if (this.listSelectedMaxApstractionClass.Count < 1) // less than 1 selected
            {
                MessageBox.Show("You must select 1 class!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.cbShowDetails.Checked = false;
            } else // ready to show info
            {
                this.refreshListBoxes();
                this.lblClassName.Text = "Class name: " + this.listSelectedMaxApstractionClass[0].name;
                this.pnlRight.Enabled = true;
            }
        }

        private List<string> getAllPropStrings()
        {
            List<string> propNames = new List<string>();
            foreach(Property prop in this.listSelectedMaxApstractionClass[0].properties)
            {
                propNames.Add(prop.getAccessor() + " " + prop.getDataType() + " " + prop.getName());
            }
            return propNames;
        }

        private List<string> getAllMethodStrings()
        {
            List<string> methodNames = new List<string>();
            foreach (Method method in this.listSelectedMaxApstractionClass[0].methods)
            {
                methodNames.Add(method.getAccessor() + " " + method.getName());
            }
            return methodNames;
        }

        private void refreshListBoxes()
        {
            this.lbClassProperties.DataSource = this.getAllPropStrings();
            this.lbClassMethods.DataSource = this.getAllMethodStrings();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if(this.tfAddPropName.Text == "" || this.tfAddPropDataType.Text == "") // something is empty
            {
                MessageBox.Show("You must fill in all fields!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            } else // filled in and ready
            {
                this.listSelectedMaxApstractionClass[0].addProperty(new Property(this.cbAddPropertyAccessor.SelectedItem.ToString(), this.tfAddPropDataType.Text.ToString(), this.tfAddPropName.Text.ToString()));
                this.refreshListBoxes();
            }
        }

        private void btnAddMethod_Click(object sender, EventArgs e)
        {
            if (this.tfAddMethodName.Text == "") // something is empty
            {
                MessageBox.Show("You must fill in all fields!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else // filled in and ready
            {
                this.listSelectedMaxApstractionClass[0].addMethod(new Method(this.cbAddMethodAccessor.SelectedItem.ToString(), this.tfAddMethodName.Text.ToString()));
                this.refreshListBoxes();
            }
        }

        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            this.tfClassName.Enabled = true;
        }

        private void rbSelect_CheckedChanged(object sender, EventArgs e)
        {
            this.tfClassName.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(this.tfConnTitle.Text == "") // prazan je
            {
                MessageBox.Show("You must enter the title!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            switch (this.cbxConnectionType.SelectedIndex)
            {
                case 0: // asocijacija
                    Association a = new Association(this.cbxConnCardFirst.SelectedItem.ToString(), this.cbxConnCardSecond.SelectedItem.ToString(), this.tfConnTitle.Text.ToString(), this.listSelectedMaxApstractionClass[0], this.listSelectedMaxApstractionClass[1]);
                    a.draw(this.listSelectedMaxApstractionClass[0].classRec, this.listSelectedMaxApstractionClass[1].classRec, this.g);
                    a.drawText(g);
                    this.listOfConnections.Add(a);
                    break;
                case 1:
                    Aggregation agg = new Aggregation(this.cbxConnCardFirst.SelectedItem.ToString(), this.cbxConnCardSecond.SelectedItem.ToString(), this.tfConnTitle.Text.ToString(), this.listSelectedMaxApstractionClass[0], this.listSelectedMaxApstractionClass[1]);
                    agg.draw(this.listSelectedMaxApstractionClass[0].classRec, this.listSelectedMaxApstractionClass[1].classRec, this.g);
                    agg.drawText(g);
                    this.listOfConnections.Add(agg);
                    break;
                case 2:
                    Composition c = new Composition(this.cbxConnCardFirst.SelectedItem.ToString(), this.cbxConnCardSecond.SelectedItem.ToString(), this.tfConnTitle.Text.ToString(), this.listSelectedMaxApstractionClass[0], this.listSelectedMaxApstractionClass[1]);
                    c.draw(this.listSelectedMaxApstractionClass[0].classRec, this.listSelectedMaxApstractionClass[1].classRec, this.g);
                    c.drawText(g);
                    this.listOfConnections.Add(c);
                    break;
                case 3:
                    Generalisation gen = new Generalisation("", "", this.tfConnTitle.Text.ToString(), this.listSelectedMaxApstractionClass[0], this.listSelectedMaxApstractionClass[1]);
                    gen.draw(this.listSelectedMaxApstractionClass[0].classRec, this.listSelectedMaxApstractionClass[1].classRec, this.g);
                    gen.drawText(g);
                    this.listOfConnections.Add(gen);
                    break;
                case 4:
                    Realization r = new Realization(this.cbxConnCardFirst.SelectedItem.ToString(), this.cbxConnCardSecond.SelectedItem.ToString(), this.tfConnTitle.Text.ToString(), this.listSelectedMaxApstractionClass[0], this.listSelectedMaxApstractionClass[1]);
                    r.draw(this.listSelectedMaxApstractionClass[0].classRec, this.listSelectedMaxApstractionClass[1].classRec, this.g);
                    r.drawText(g);
                    this.listOfConnections.Add(r);
                    break;
            }
        }

        private void cbxConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbxConnectionType.SelectedIndex == 3) // generalizacija
            {
                this.cbxConnCardFirst.Enabled = false;
                this.cbxConnCardSecond.Enabled = false;
            } else
            {
                this.cbxConnCardFirst.Enabled = true;
                this.cbxConnCardSecond.Enabled = true;
            }
        }
    }
}
