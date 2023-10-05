using CGPACalculator.Helpers;

namespace CGPACalculator
{
    public partial class Form1 : Form
    {
        //private int markSP, markTOC, markDT, markOS, markOSL, markADB, markADBL, markOOP, markNAL;

        private List<int> marks3y1s = new List<int>();
        private List<double> gradePoints3y1s = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                marks3y1s.Clear();
                marks3y1s.Add(Int32.Parse(txtSP.Text));
                marks3y1s.Add(Int32.Parse(txtTOC.Text));
                marks3y1s.Add(Int32.Parse(txtDT.Text));
                marks3y1s.Add(Int32.Parse(txtOS.Text));
                marks3y1s.Add(Int32.Parse(txtOSL.Text));
                marks3y1s.Add(Int32.Parse(txtADB.Text));
                marks3y1s.Add(Int32.Parse(txtADBL.Text));
                marks3y1s.Add(Int32.Parse(txtOOP.Text));
                marks3y1s.Add(Int32.Parse(txtNAL.Text));
                bool hasValueGreaterThan100 = marks3y1s.Any(mark => mark > 100);
                //bool hasValueLessThan40 = marks3y1s.Any(mark => mark < 40);

                if (hasValueGreaterThan100)
                {
                    MessageBox.Show("One or more input contains value more than 100!");
                }
                /*else if (hasValueLessThan40) {
                    txtGPA.Text = "0.0";
                }*/
                else
                {
                    gradePoints3y1s.Clear();
                    marks3y1s.ForEach(mark =>
                    {
                        gradePoints3y1s.Add(GlobalHelpers.getGradePoint(mark));
                    });

                    bool hasFailed = gradePoints3y1s.Any(g => g == 0.0);
                    if (hasFailed)
                    {
                        txtGPA.Text = "0.0";
                        //MessageBox.Show("Failed");


                    }
                    else
                    {
                        txtGPA.Text = GlobalHelpers.getGpa(gradePoints3y1s).ToString("F2");

                    }
                    txtSPG.Text = gradePoints3y1s[0].ToString();
                    txtTOCG.Text = gradePoints3y1s[1].ToString();
                    txtDTG.Text = gradePoints3y1s[2].ToString();
                    txtOSG.Text = gradePoints3y1s[3].ToString();
                    txtOSLG.Text = gradePoints3y1s[4].ToString();
                    txtADBG.Text = gradePoints3y1s[5].ToString();
                    txtADBLG.Text = gradePoints3y1s[6].ToString();
                    txtOOPG.Text = gradePoints3y1s[7].ToString();
                    txtNALG.Text = gradePoints3y1s[8].ToString();

                    txtSPGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[0]);
                    txtTOCGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[1]);
                    txtDTGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[2]);
                    txtOSGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[3]);
                    txtOSLGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[4]);
                    txtADBGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[5]);
                    txtADBLGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[6]);
                    txtOOPGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[7]);
                    txtNALGL.Text = GlobalHelpers.getLetterGrade(gradePoints3y1s[8]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("One or more input fields are empty!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSP.Clear();
            txtTOC.Clear();
            txtDT.Clear();
            txtOS.Clear();
            txtOSL.Clear();
            txtADB.Clear();
            txtADBL.Clear();
            txtOOP.Clear();
            txtNAL.Clear();

            txtGPA.Clear();
            
            txtSPG.Clear();
            txtTOCG.Clear();
            txtDTG.Clear();
            txtOSG.Clear();
            txtOSLG.Clear();
            txtADBG.Clear();
            txtADBLG.Clear();
            txtOOPG.Clear();
            txtNALG.Clear();
            
            txtSPGL.Clear();
            txtTOCGL.Clear();
            txtDTGL.Clear();
            txtOSGL.Clear();
            txtOSLGL.Clear();
            txtADBGL.Clear();
            txtADBLGL.Clear();
            txtOOPGL.Clear();
            txtNALGL.Clear();
        }

    }
}