using task3;

var doctor = new Doctor("Dr. Johnson", "Cardiologist" , 20);
System.Console.Write("Doctor's Name:");
System.Console.WriteLine(doctor.GetName());
System.Console.Write("Medical Specialty:");
System.Console.WriteLine(doctor.GetSpecialty());
System.Console.Write("Years of Experience:");
System.Console.WriteLine(doctor.GetExperience());
System.Console.WriteLine(doctor.TreatPatiente("Emily Parker."));
System.Console.WriteLine(doctor.PerformMedicalExamination("Emily Parker"));
System.Console.WriteLine(doctor.PrescribeMedication("James Brown","Anthibiotics"));

