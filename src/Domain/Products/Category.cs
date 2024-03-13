
using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace IWantApp.Domain.Products;

public class Category : Entity
{
    public string Name { get; private set; }
    public bool Active { get; private set; }

    public Category(string name, string createdBy, string editedBy)
    {
        Name = name;
        Active = true;
        CreateBy = createdBy;
        EditBy = editedBy;
        CreateOn = DateTime.Now;
        EditOn = DateTime.Now;

        Validate();

    }

    private void Validate()
    {
        var contract = new Contract<Category>()
            .IsNotNullOrEmpty(Name, "Name")
            .IsGreaterOrEqualsThan(Name, 3, "Name")
            .IsNotNullOrEmpty(CreateBy, "CreatedBy")
            .IsNotNullOrEmpty(EditBy, "EditedBy");
        AddNotifications(contract);
    }

    public void EditInfo(string name, bool active)
    { 
        Active = active;
        Name = name;

        Validate();

    }
}