using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_client
{
    public partial class Form1 : Form
    {
        String URL = "http://localhost/REST_server/";
        String ROUTE ="index.php";

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAll_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);

            IRestResponse<List<Videogame>> response = client.Execute<List<Videogame>>(request);

            ClearListBox();

            listBox1.Items.Add("All Videogames:");
            foreach (Videogame v in response.Data)
            {
                listBox1.Items.Add("ID:" + v.id + " title: " + v.title + " publisher: " + v.publisher +" price:" + v.price);
            }
        }

        private void GetGameById_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            int id = (int)get_game_by_id_numeric.Value;
            String ROUTE = "index.php?id=" + id;
            var request = new RestRequest(ROUTE, Method.GET);

            ClearListBox();

            if (id == 0)
            {
                listBox1.Items.Add("All Videogames:");
            }
            else
            {
                listBox1.Items.Add("Videogame by id:" + get_game_by_id_numeric.Value);
            }

            IRestResponse<List<Videogame>> response = client.Execute<List<Videogame>>(request);         
            foreach (Videogame v in response.Data)
            {
                listBox1.Items.Add("ID:" + v.id + " title: " + v.title + " publisher: " + v.publisher + " price:" + v.price);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            string ROUTE = "index.php/delete?id="+delete_id_numeric.Value;
            var request = new RestRequest(ROUTE,Method.DELETE);

            //request.AddParameter("id",delete_id_numeric.Value, ParameterType.UrlSegment);
            request.AddJsonBody(new {
                //id, 
                authkey = authKeyBox.Text
            });

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Videogame Deleted");
            }
            else
            {
                MessageBox.Show("Videogame deletion failed: " + Enum.GetName(typeof(HttpStatusCode), response.StatusCode));
            }
            ClearAuthKeyBox();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                authkey = authKeyBox.Text,
                title = title_tb.Text,
                publisher = publisher_tb.Text,
                price = (int)insert_price_numeric.Value
            });
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Videogame Inserted");
            }
            else
            {
                MessageBox.Show("Videogame insertion failed: " + Enum.GetName(typeof(HttpStatusCode), response.StatusCode));
            }
            ClearAuthKeyBox();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new Videogame
            {
                authkey = authKeyBox.Text,
                id = (int)id_update_numeric.Value,
                title = title_update_tb.Text,
                publisher = publisher_update_tb.Text,
                price = (int)price_update_numeric.Value
            });
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Videogame Updated");
            }
            else
            {
                MessageBox.Show("Videogame update failed: " + Enum.GetName(typeof(HttpStatusCode), response.StatusCode));
            }
            ClearAuthKeyBox();
        }

        private void ClearAuthKeyBox()
        {
            authKeyBox.Clear();
        }

        private void ClearListBox()
        {
            listBox1.Items.Clear();
        }
    }
}
