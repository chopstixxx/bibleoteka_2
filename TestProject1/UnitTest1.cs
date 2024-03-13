using ClassLibrary;
using NUnit.Framework;
using System.Data;

namespace TestProject1
{
    public class Tests

    {
        DB db;
        [SetUp]
        public void Setup()
        {
            db = new DB();
        }

        [Test]
        public void Test_open_conn_true()
        {
            db.Open_conn();
            Assert.IsTrue(db.Get_conn().State == System.Data.ConnectionState.Open);
        }
        [Test]
        public void TestGet_conn_false()
        {
            Assert.IsTrue(db.Get_conn().State == System.Data.ConnectionState.Closed);
        }
        [Test]
        public void Test_goods_load_true()
        {
            bool hasrows;
          DataTable dt =  db.Goods_load();
            if(dt.Rows.Count > 0) { hasrows = true; }
            else { hasrows = false; }
            Assert.IsTrue(hasrows);
            
        }
        [Test]
        public void Test_task_load_true()
        {
            bool hasrows;
            DataTable dt = db.Task_load(2);
            if (dt.Rows.Count > 0) { hasrows = true; }
            else { hasrows = false; }
            Assert.IsTrue(hasrows);

        }
        [Test]
        public void Test_add_goods_true()
        {
            Assert.IsTrue(db.Project_add("test", "test"));

        }
        [Test]
        public void Test_add_task_true()
        {
            Assert.IsTrue(db.Task_add(2,"test", "test"));

        }


    }
}
    
