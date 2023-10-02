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
                        txtGPA.Text = GlobalHelpers.getGpa(gradePoints3y1s).ToString();

                    }


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
        }

    }
}