using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BELayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DALayer
{
    public class EmployeeServiceAPI
    {
        public static readonly String baseURL = "https://gorest.co.in/public-api";
        public static readonly ObservableCollection<Employee> employees;
        public async Task<ObservableCollection<Employee>> GetAllEmployeeDetails()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            var url = "https://gorest.co.in/public-api/users";
            using (var client = new HttpClient())
            {
                var msg = new HttpRequestMessage(HttpMethod.Get, url);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                var res = await client.SendAsync(msg);
                var content = await res.Content.ReadAsStringAsync();

               // JObject Employee = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(content);
                JObject jo = JObject.Parse(content);
                var test = jo.SelectToken("data");

                foreach (var property in test)
                {

                    Employee employee = new Employee();
                    employee.id = Convert.ToInt32(property["id"]);
                    employee.name = Convert.ToString(property["name"]);
                    employee.email = Convert.ToString(property["email"]);
                    employee.gender = Convert.ToString(property["gender"]);
                    employee.status = Convert.ToString(property["status"]);
                    employees.Add(employee);

                }
                return employees;
            }
        }

        public async Task<Employee> CreateEmployee(Employee emp)
        {
            var url = "https://gorest.co.in/public-api/users";
            using (HttpClient client = new HttpClient())
            {
                var data = JsonConvert.SerializeObject(emp);
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Content = new StringContent(data, Encoding.UTF8);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var createdCompany = JsonConvert.DeserializeObject<Employee>(content);
                return createdCompany;
            }
        }

        public static async Task Update(Employee emp)
        {
            var url = $@"https://gorest.co.in/public-api/users/{emp.id}";
            using (HttpClient client = new HttpClient())
            {
                var message = JsonConvert.SerializeObject(emp);
                var requestContent = new StringContent(message, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                var response = await client.PutAsync(url, requestContent);
                response.EnsureSuccessStatusCode();
            }
        }
        public static async Task Delete(int id)
        {
            var url = "https://gorest.co.in/public-api/users/";
            using (var client = new HttpClient())
            {
                var msg = new HttpRequestMessage(HttpMethod.Delete, url + id);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                //var response = await client.SendAsync(msg);
                msg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.SendAsync(msg);
                response.EnsureSuccessStatusCode();
            }
        }




    }
}
