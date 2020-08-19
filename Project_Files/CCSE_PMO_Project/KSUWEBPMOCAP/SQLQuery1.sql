SELECT Project_Num, Faculty_LastName, Sponsor_Name, Student_LastName
FROM Project Full JOIN Faculty ON Project.Project_ID = Faculty.Faculty_ID
Left Join Sponsor ON Project.Project_ID = Sponsor.Sponsor_ID
Right JOin Student ON Project.Project_ID = Student.Student_ID
