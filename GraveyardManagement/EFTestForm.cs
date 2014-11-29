using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraveyardManagement.Model;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement
{
    public partial class EFTestForm: Form
    {
        EFTestModel eftest;

        public EFTestForm()
        {
            InitializeComponent();
            eftest = new EFTestModel();
            
            test();
        }

        public void test()
        {
            eftest.Entities.Religie.Add(new Religie() { nume = "Ortodox"});
            eftest.Entities.Religie.Add(new Religie() { nume = "Musulman"});

            eftest.Entities.SaveChanges();

            var query = 
                from religie in eftest.Entities.Religie 
                where religie.nume == "Musulman" 
                select religie;

            foreach (var religie in query)
            {
                this.Controls.Add(new Label() { Text =  religie.id + " " + religie.nume});
            }

        }
    }
}
