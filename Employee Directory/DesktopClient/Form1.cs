using SharedLibrary.DTO;
using System.Data;
using System.Net.Http.Json;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var employeeList = await client.GetFromJsonAsync<List<EmployeeDto>>("https://localhost:7002/api/employee");

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
            dataTable.Columns.Add("Department", typeof(string));

            foreach (var employee in employeeList)
            {
                dataTable.Rows.Add(employee.Name, employee.Position, employee.Department);
            }

            employeeDataGrid.DataSource = dataTable;

        }

    }
}