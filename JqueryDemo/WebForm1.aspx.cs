using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JqueryDemo
{
    public class Employee
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string email { set; get; }
        public int age { set; get; }

    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = "[{\"firstName\":\"TEDU\",\"lastName\":\"App\",\"email\":\"tedu @gmail.com\",\"age\":14},{\"firstName\":\"John\",\"lastName\":\"Ab\",\"email\":\"john @gmail.com\",\"age\":16}]";

            JavaScriptSerializer javascriptSerializer = new JavaScriptSerializer();

            //json to object .net
            var lisEmployee = javascriptSerializer.Deserialize<List<Employee>>(json);

            //object to string json
            var strJson = javascriptSerializer.Serialize(lisEmployee);

            Response.Write(strJson);
        }
    }
}