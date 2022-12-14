using BookingManagerLibrary.DataAccess;
using BookingManagerLibrary.Models;

namespace BookingManager.Views;

public partial class CustomerView : ContentPage
{
    private readonly BookingDataAccess bookingDataAccess;
    private List<Customer> customers;
    public List<Customer> Customers
    {
        get => customers;
        set
        {
            customers = value;
            OnPropertyChanged(nameof(Customers));
        }
    }

    private Customer selectedCustomer;
    public Customer SelectedCustomer
    {
        get => selectedCustomer;
        set
        {
            selectedCustomer = value;
            OnPropertyChanged(nameof(SelectedCustomer));
        }
    }

    private Customer selectedBillingProfile;
    public Customer SelectedBillingProfile
    {
        get => selectedBillingProfile;
        set
        {
            selectedBillingProfile = value;
            OnPropertyChanged(nameof(SelectedBillingProfile));
        }
    }

    public CustomerView()
	{
        InitializeComponent();
        bookingDataAccess = new BookingDataAccess();
        Customers = new List<Customer>();
        GetCustomers();
    }

    public Command GetCustomers()
    {
        var result = bookingDataAccess.GetCustomers(null, null, active);

    }


    void CustomerSelected(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        var employeeGrid = sender as Grid;
        if (employeeGrid != null)
        {
            var employee = employeeGrid.BindingContext as Employee;
            if (employee != null)
                SelectedCustomer = employee;
        }
    }

    void BillingProfileSelected(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        var employeeGrid = sender as Grid;
        if (employeeGrid != null)
        {
            var employee = employeeGrid.BindingContext as Employee;
            if (employee != null)
                SelectedBillingProfile = employee;
        }
    }
}
