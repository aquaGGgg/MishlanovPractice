using System;

class Application
{
    public int ApplicationNumber { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? DateCompleted { get; set; }
    public string TypeOfEquipment { get; set; }
    public string Model { get; set; }
    public string ProblemDescription { get; set; }
    public string ClientLastName { get; set; }
    public string ClientFirstName { get; set; }
    public string ClientMiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Master { get; set; }
    public string Comments { get; set; }
    public string OrderedParts { get; set; }
}

