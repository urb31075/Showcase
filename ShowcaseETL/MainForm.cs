// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="urb31075">
//  All Right Reserved 
// </copyright>
// <summary>
//   Defines the MainForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ShowcaseETL
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The test.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int Test()
        {
            return 10;
        }

        /// <summary>
        /// The create staff iq button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CreateStaffIqButtonClick(object sender, EventArgs e)
        {
            var staffIqTestEntities = new StaffIQTestEntities();

            /*for (var i = 1; i <= 1024; i++)
            {
                var staffIQ = new StaffIQ();
                staffIQ.IQ = 100;
                staffIQTestEntities.StaffIQ.Add(staffIQ);
            }*/

            /*for (var i = 1; i <= 1024; i++)
            {
                // var department = new Department();
                var department = staffIQTestEntities.Department.Where(c => c.id == i).FirstOrDefault();
                department.StaffId = i;
                department.DepartmentId = 1 + (i -1) / 16;
                department.Name = string.Format("Отдел № {0}", department.DepartmentId);

                //staffIQTestEntities.Department.Add(department);
            }*/

            /*for (var i = 1; i <= 16; i++)
            {
                var department = staffIQTestEntities.Department.Where(c => c.id == i).FirstOrDefault();
                department.DepartmentId = 40;
                department.Name = string.Format("Отдел № {0}", department.DepartmentId);
            }

            for (var i = 625; i <= 640; i++)
            {
                var department = staffIQTestEntities.Department.Where(c => c.id == i).FirstOrDefault();
                department.DepartmentId = 1;
                department.Name = string.Format("Отдел № {0}", department.DepartmentId);
            }*/
            staffIqTestEntities.SaveChanges();

            this.ViewInfoListBox();
        }

        /// <summary>
        /// The update age button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateAgeButtonClick(object sender, EventArgs e)
        {
            var staffIqTestEntities = new StaffIQTestEntities();
            var rnd = new Random();
            for (var i = 1; i <= 1024; i++)
            {
                var age = new Age();
                age.StaffId = i;
                age.Value = 20 + rnd.Next(50);
                if (age.Value < 30)
                {
                    age.Name = "молодой";
                }
                else if (age.Value < 40)
                {
                    age.Name = "средний";
                }
                else
                {
                    age.Name = "старший";
                }

                staffIqTestEntities.Age.Add(age);
            }

            staffIqTestEntities.SaveChanges();
        }

        /// <summary>
        /// The update floor button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateFloorButtonClick(object sender, EventArgs e)
        {
            /*var staffIQTestEntities = new StaffIQTestEntities();

            for (var i = 1; i <= 1024; i++)
            {
                var floor = new Floor();
                floor.StaffId = i;
                floor.Value = 1 + (i - 1) / 85;
                floor.Name = string.Format("Этаж № {0}", floor.Value);
                staffIQTestEntities.Floor.Add(floor);
            }

            staffIQTestEntities.SaveChanges();*/
            this.ViewInfoListBox();
        }

        /// <summary>
        /// The update gender button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateGenderButtonClick(object sender, EventArgs e)
        {
            var staffIqTestEntities = new StaffIQTestEntities();
            var rnd = new Random();
            for (var i = 1; i <= 1024; i++)
            {
                var gender = new Gender { StaffId = i };
                var x = rnd.Next(10);
                if (x < 5)
                {
                    gender.Value = 0;
                    gender.Name = "М";
                }
                else
                {
                    gender.Value = 1;
                    gender.Name = "Ж";
                }

                staffIqTestEntities.Gender.Add(gender);
            }

            staffIqTestEntities.SaveChanges();
        }

        /// <summary>
        /// The update staff iq button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateStaffIqButtonClick(object sender, EventArgs e)
        {
            var staffIqTestEntities = new StaffIQTestEntities();

            for (var id = 1; id <= 16; id++)
            {
                var staffIq = staffIqTestEntities.StaffIQ.FirstOrDefault(c => c.id == id);
                if (staffIq != null)
                {
                    staffIq.IQ = 48 + (id * 3);
                }
            }

            for (var id = 1; id <= 16; id++)
            {
                var staffIq = staffIqTestEntities.StaffIQ.FirstOrDefault(c => c.id == 1008 + id);
                if (staffIq != null)
                {
                    staffIq.IQ = 100 + (id * 3);
                }
            }

            staffIqTestEntities.SaveChanges();

            var rnd = new Random();
            for (var id = 1; id <= 1024; id++)
            {
                var staffIq = staffIqTestEntities.StaffIQ.FirstOrDefault(c => c.id == id);
                if (staffIq != null)
                {
                    staffIq.IQ = staffIq.IQ + rnd.Next(20) - 10;
                }
            }

            staffIqTestEntities.SaveChanges();

            this.ViewInfoListBox();
        }

        /// <summary>
        /// The view info list box.
        /// </summary>
        private void ViewInfoListBox()
        {
            this.InfoListBox.Items.Clear();
            var staffIqTestEntities = new StaffIQTestEntities();

            /*foreach (var staff in staffIQTestEntities.StaffIQ)
            {
                InfoListBox.Items.Add(string.Format("{0} {1}", staff.id, staff.IQ));
            }*/
            foreach (var item in staffIqTestEntities.Department)
            {
                this.InfoListBox.Items.Add(string.Format("{0} {1} {2}", item.id, item.DepartmentId, item.Name));
            }
        }
    }
}