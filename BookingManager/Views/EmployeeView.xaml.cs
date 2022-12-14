using BookingManagerLibrary.DataAccess;
using BookingManagerLibrary.Models;

namespace BookingManager.Views;

public partial class EmployeeView : ContentPage
{
	private readonly BookingDataAccess bookingDataAccess;
	private List<Employee> employees;
	public List<Employee> Employees
	{
		get => employees;
		set
		{
			employees = value;
			OnPropertyChanged(nameof(Employees));
		}
	}

	private Employee selectedEmployee;
	public Employee SelectedEmployee
	{
		get => selectedEmployee;
		set
		{
			selectedEmployee = value;
			OnPropertyChanged(nameof(SelectedEmployee));
		}
	}

    private bool showCreateUpdateEmployee;
    public bool ShowCreateUpdateEmployee
    {
        get => showCreateUpdateEmployee;
        set
        {
            showCreateUpdateEmployee = value;
            OnPropertyChanged(nameof(ShowCreateUpdateEmployee));
        }
    }

    public EmployeeView()
	{
		InitializeComponent();
		bookingDataAccess = new BookingDataAccess();
		Employees = new List<Employee>();
		GetEmployees();
	}

    void Employee_Selected(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
		var employeeGrid = sender as Grid;
		if(employeeGrid != null)
		{
			var employee = employeeGrid.BindingContext as Employee;
			if (employee != null)
				SelectedEmployee = employee;
		}
    }

	private void GetEmployees()
	{
		bookingDataAccess.GetEmployees();
        OnPropertyChanged(nameof(Employees));
    }

	private Command ShowCreateNewEmployee()
	{
		ShowCreateUpdateEmployee = true;
		selectedEmployee = new Employee();
	}

	private Command CreatNewEmployee()
	{
		bookingDataAccess.CreateUser(selectedEmployee);
	}
}
