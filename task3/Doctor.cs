namespace task3;

public class Doctor
{
string _fullName;
string _specialty;
int _experience;

public Doctor()
{
    
}
public Doctor(string fullName,string specialty)
{
    _fullName = fullName;
    _specialty = specialty;
}
public Doctor(string fullName,string specialty,int experience)
{
    _fullName = fullName;
    _specialty = specialty;
    _experience = experience; 
}
public string TreatPatiente(string patientName)
{
    return $"{_fullName} {_specialty} is treating a patient named {patientName}.";
}
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullName} is performing a medical examination on {patientName}.";
    }
    public string PrescribeMedication(string patientName,string medication)
    {
        return $"{_fullName}prescribes {medication} for {patientName} ";
    }
    public void SetExperience(int years)
    {
        _experience = years;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public string GetName()
    {
        return _fullName;
    }
    public string GetSpecialty()
    {
        return _specialty;
    }

}
