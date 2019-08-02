using COMP123_S2019_A5_301045522.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301045522
{
  public static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        //public static OrderForm orderForm;
        //public static SelectForm selectForm;
        //public static StartForm startForm;
        //public static ProductInfoForm productInfoForm;
        //public static SplashForm splashForm;
        //public static AboutForm aboutForm;

        //public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_FORM, new SplashForm());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new AboutForm());
            //orderForm = new OrderForm();
            //selectForm = new SelectForm();
            //startForm = new StartForm();
            //productInfoForm = new ProductInfoForm();
            //splashForm = new SplashForm();
            //aboutForm = new AboutForm();
            ////product = new Product();
            Application.Run(Forms[FormNames.SPLASH_FORM]);
        }
    }
}
