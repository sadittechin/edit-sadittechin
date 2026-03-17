# sadittechin rattanaphong 683450194-7
                    +----------------------+
                    |        Person        |
                    |     <<abstract>>     |
                    +----------------------+
                    | - name : string      |
                    +----------------------+
                    | + Name : string      |
                    | + ShowInfo()         |
                    +----------------------+
                              ▲
                              |
               --------------------------------
               |                              |
     +---------------------+        +--------------------+
     |       Student       |        |       Teacher      |
     +---------------------+        +--------------------+
     | - studentId : string|        |                    |
     | - score : double    |        +--------------------+
     +---------------------+        | + ShowInfo()       |
     | + StudentId         |        +--------------------+
     | + Score             |
     | + GetGrade()        |
     | + ShowInfo()        |
     +---------------------+

                     |
                     | 1
                     |
                     | *
             +----------------------------+
             |           Course           |
             +----------------------------+
             | + CourseId : string        |
             | + CourseName : string      |
             | - students : List<Student> |
             +----------------------------+
             | + AddStudent()             |
             | + ShowStudents()           |
             | + ShowMaxScore()           |
             | + ShowMinScore()           |
             | + ShowAverageScore()       |
             +----------------------------+
