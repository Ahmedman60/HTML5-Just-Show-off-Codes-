using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
public partial class process : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("data source =ACER; Database=Pharmacy; integrated security = true;");
 
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Open();
        Label1.Text = cn.State.ToString();
        cn.Close();
        
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlDataAdapter cm1 = new SqlDataAdapter("Select drugid,price,drugname from drugs where drugname like '"+"%"+TextBox1.Text+"%"+"'", cn);
        DataSet sr = new DataSet();
       
            cm1.Fill(sr,"Drugs");

        GridView1.DataSource = sr.Tables[0];
        DataBind();
        //Using dataBiding to Connect an Element Whit A coloum in The DataBase.
       






        cn.Close();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //cm2.CommandText = "slectcustomer";
        //cm2.Connection = cn;
        try
        {
            SqlCommand cm2 = new SqlCommand("slectcustomer", cn);
            cm2.CommandType = CommandType.StoredProcedure;

            //SqlParameter p1 = new SqlParameter("@id", TextBox2.Text);
            //cm2.Parameters.Add(p1);

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", TextBox2.Text);
            cm2.Parameters.AddRange(parm);
            /*
             لو inster
             cm2.excutenonquery
             select
             Cm.excutereader وحطه فى sqldatareader

            */
            // parm[1]=new sqlparamter();
            //وهكدذا لو عندك اكتر من paramter و عاوز تعمل insert
            //وبعد كده تضيف الparam للكومند

            cn.Open();
            SqlDataReader dr = cm2.ExecuteReader();

            GridView2.DataSource = dr;
            GridView2.DataBind();
            dr.Close();
        }
        catch (Exception )
        {
            Label1.Text = "SomeThing gose wrong";
            
        }
        finally
        {
            cn.Close();
            
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        string filepath = @"D:\upload";
        string filename = FileUpload1.FileName;
        string thefullpath = Path.Combine(filepath, filename);
        //save as

        if (Directory.Exists(filepath))
        {
            FileUpload1.PostedFile.SaveAs(thefullpath);
        }
        else
        {
            Directory.CreateDirectory(filepath);
            math();
        } }
         public void math()
    {
        string filepath = @"D:\upload";
        string filename = FileUpload1.FileName;
        string thefullpath = Path.Combine(filepath, filename);
        FileUpload1.PostedFile.SaveAs(thefullpath);
    }



}
