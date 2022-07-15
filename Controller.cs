using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_Project
{
	public class Controller
	{
		DBManager dbMan;

		public Controller()
		{
			dbMan = new DBManager();
		}
		public int CreateNewUser(string username, string password)
		{
			string ins = "Instr";
			string query = "INSERT INTO UserType VALUES ('" + username + "','" + password + "','" + ins + "')";
			return dbMan.ExecuteNonQuery(query);
		}

		public int AddAttendnace(string name, int name2, char age, int number)
		{
			string query = "INSERT INTO STUDENT_ATTENDANCE VALUES(" + int.Parse(name) + ", " + name2 + ", '" + age + "', " + number + "); ";
			return dbMan.ExecuteNonQuery(query);
		}
		//Password Change//
		public int UpdatePassword(string uname, string password, string newpass)
		{
			string u = "Admin";
			string query = "UPDATE UserType Set Password ='" + newpass+"' Where username='"+uname+"' and password='"+password+"' and type ='"+u+"'";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable TotalCredits(int stuid)
		{
			string query = "Select distinct sum(c.credithours) AS TotalCreditHours from Student S,Course C,Takes T " +
				"where c.CourseID=t.CourseID and s.StudentID=t.StudentID and s.StudentID='"+stuid+"'" +
				"group by s.StudentID,S.FName,S.Minit,S.LName Order by TotalCreditHours DESC";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SELECTSTUDENTLIST(int instid, int courseID)
		{
			string query = "SELECT distinct S.StudentID,S.FName,S.LName " +
				"FROM Takes T, STUDENT S " +
				"WHERE S.StudentID = T.StudentID AND T.CourseID = " + courseID + " " +
				"AND EXISTS(SELECT* FROM Instructor I, Teaches T Where I.InstructorID=" + instid + "  AND T.CourseID = " + courseID + ") ";
			return dbMan.ExecuteReader(query);
		}

		public DataTable SELECTSTUDENTLIST2()
		{
			string query = "SELECT * FROM Student;";
			return dbMan.ExecuteReader(query);

		}

		public DataTable SelectTranscript(int id)
		{
			string query = "(SELECT C.CourseName, C.CourseID " +
				"FROM BelongsTo as B,STUDENT as S, course as C " +
				"WHERE B.DepartmentID = S.DepID AND C.CourseID = B.CourseID AND S.StudentID = " + id + ") " +
				"EXCEPT " +
				"(SELECT C.CourseName, C.CourseID AS ID " +
				"FROM Takes AS T, Course as C " +
				"Where T.StudentID = "+id+" AND C.CourseID = T.CourseID);";
			return dbMan.ExecuteReader(query);


		}
		public DataTable GetUserName(int id)
		{
			string query = " SELECT username " +
				"From Instructor " +
				"Where InstructorID = " + id + ";";
			return dbMan.ExecuteReader(query);
		}
		public int UpdateInst(string UserNameold, string password, string UserNamenew)
		{
			string query = "UPDATE UserType SET username = '" + UserNamenew + "', password= '" + password + "' where username = '" + UserNameold + "'";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable UpdatingUserNameCheck()
		{
			string query = "SELECT * FROM Usertype;";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CheckUser(string username, string password)
		{
			string query = "SELECT * FROM UserType " +
				"WHERE USERNAME='" + username + "' " +
				"AND PASSWORD='" + password + "' COLLATE SQL_Latin1_General_CP1_CS_AS ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable UserType()
		{
			string query = "SELECT * From UserType";
			return dbMan.ExecuteReader(query);
		}

		public DataTable GetInstructorName(int ID)
		{
			string query = "SELECT FirstName From Instructor where InstructorID = " + ID + " ";
			return dbMan.ExecuteReader(query);
		}

		public DataTable GetHisID(string username)
		{
			string query = "SELECT InstructorID FROM Instructor Where username = '" + username + "' ";
			return dbMan.ExecuteReader(query);

		}
		public int AddNewUser(string username, string password)
		{
			string type = "Admin";
			string query = "INSERT INTO UserType VALUES ('" + username + "','" + password + "','" + type + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectStudentswithID(int ID)
		{
			string query = "SELECT FName As FirstName,Minit As MiddleInitial,LName As LastName,StudentID,Gender,BDate As Birthdate,Phone,DepartmentName,Class As Year FROM Student,Department Where DepartmentID=DepID AND StudentID = '" + ID+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectDepartment()
		{
			string query = "SELECT DepartmentName,DepartmentID,Mgr_Id FROM Department";
			return dbMan.ExecuteReader(query);
		}
		public int DeleteStudent(int id)
		{
			string query = "DELETE FROM Student WHERE StudentID='" + id + "';";
			return dbMan.ExecuteNonQuery(query);
		}
		public int UpdateStudent(string fname, char minit, string lname, string sex, DateTime date, string phone, int depid, string clas,int id)
		{
			string query = "UPDATE STUDENT SET Class='" + clas + "', Gender='" + sex + "'," +
				"DepID='" + depid + "',BDate='" + date + "',FName='" + fname + "',Minit='" + minit + "',LName='" + lname + "'," +
				" Phone = '" + phone + "' WHERE StudentID='" + id + "';";
			return dbMan.ExecuteNonQuery(query);
		}
		public int UpdateCourse(string day, DateTime start, DateTime end,int cid)
		{
			string query = "UPDATE Course SET Day='" + day + "', StartHour='" + start + "', EndHour = '"+end+"' WHERE CourseID='" + cid + "';";
			return dbMan.ExecuteNonQuery(query);
		}
		public int DeleteCourse(int cid)
		{
			string query = "DELETE FROM Course WHERE CourseID='" + cid + "';";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddPreq(int cid , int pid)
		{
			string query = "INSERT INTO Prerequisite VALUES ('" + cid + "','" + pid + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectDepID(string name)
		{
			string query = "SELECT DepartmentID FROM Department Where DepartmentName= '"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectInstID()
		{
			string query = "SELECT InstructorID FROM Instructor;";
			return dbMan.ExecuteReader(query);
		}
		public int InsertStudent(string fname, char minit, string lname, int id, string sex, DateTime date, string phone, int depid, string clas)
		{
			string query = "INSERT INTO STUDENT (FName, Minit, LName, StudentID, Gender, BDate, Phone, DepID, Class) " +
				"VALUES ('" + fname + "', '" + minit + "','" + lname + "'," + id + ",'" + sex + "'," +
				"'" + date.ToString("yyyy-MM-dd") + "','" + phone + "','" + depid + "','" + clas + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int InsertCourse(int cid, string cname, int chrs, DateTime sthr, DateTime enhr, string day)
		{
			string query = "INSERT INTO Course (CourseID, CourseName, CreditHours, StartHour, EndHour, Day) " +
			"VALUES ('" + cid + "', '" + cname + "','" + chrs + "','" + sthr.ToString("HH:mm:ss") + "','" + enhr.ToString("HH:mm:ss") + "','"+day+"');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int InsertDepartment(string dname, int id, int mid)
		{
			string query = "INSERT INTO DEPARTMENT VALUES ('" + dname + "','" + id + "','" + mid + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectBID()
		{
			string query = "SELECT BuildingID FROM Building;";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectBName()
		{
			string query = "SELECT BuildingName FROM Building;";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectSID()
		{
			string query = "SELECT StudentID FROM Student;";
				return dbMan.ExecuteReader(query);
		}
		public DataTable SelectStudentsfees(int id)
		{
			string query = "SELECT * FROM Fees Where StudentID= '"+id+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectStudentsfees()
		{
			string query = "SELECT * FROM Fees";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectDepName()
		{
			string query = "SELECT DepartmentName FROM Department;";
			return dbMan.ExecuteReader(query);
		}
		public DataTable StudentTable()
		{
			string query = "SELECT FName As FirstName,Minit As MiddleInitial,LName As LastName,StudentID,Gender,BDate As Birthdate,Phone,DepartmentName,Class As Year FROM Student,Department Where DepartmentID=DepID Order by FName";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Courses()
		{
			string query = "SELECT * From Course";
			return dbMan.ExecuteReader(query);
		}
		public DataTable RegisterCourse()
		{
			string query = "SELECT distinct C.CourseID,CourseName,RoomNumber,LevelNumber,BuildingName FROM Takes T,Course C Where C.CourseID=T.CourseID Order by C.CourseID";
			return dbMan.ExecuteReader(query);
		}
		public DataTable RegisterCourseDep(string name)
		{
			string query = "SELECT DISTINCT C.CourseID,CourseName,RoomNumber,LevelNumber,BuildingName FROM Takes T,Course C,Department D , BelongsTo B Where c.CourseID=b.CourseID and C.CourseID=T.CourseID And b.DepartmentID=D.Departmentid and DepartmentName='"+name+"' Order by C.CourseID";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectCoursename()
		{
			string query = "Select Coursename From Course";
			return dbMan.ExecuteReader(query);
		}
		public int InsertTakes(int id,int room,int level,string name,int course)
		{
			string query = "INSERT INTO Takes VALUES ('" + id + "','" + room + "','" + level + "','" + name + "','"+course+"')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectCourseID()
		{
			string query = "Select CourseID From Course ORDER BY COURSEID";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectLevelnumber()
		{
			string query = "Select LevelNumber From Room";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectRoomnumber()
		{
			string query = "Select RoomNumber From Room";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectStudentName()
		{
			string query = "SELECT Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as Name From Student ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectStudentActivity()
		{
			string query = "SELECT Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as StudentName, ActivityType AS ActivityJoined From Student S ,Activity A,Participate P " +
				"WHERE S.StudentID=P.StudentID AND A.ActivityID=P.ActivityID ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable STUCOURSE()
		{
			string query = "SELECT S.StudentID ,Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as StudentName,CourseName FROM STUDENT S,COURSE C, TAKES T WHERE S.StudentID=T.StudentID AND C.CourseID=T.CourseID ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectActivity()
		{
			string query = "SELECT ActivityType from Activity";
			return dbMan.ExecuteReader(query);
		}
		public int DeleteParticipate(int id,int aid)
		{
			string query = "DELETE FROM Participate Where StudentID = '"+id+"' AND ActivityID='"+aid+"'";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectActivity(string name)
		{
			string query = "SELECT ActivityID from Activity Where ActivityType = '"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Buildings()
		{
			string query = "Select * from building";
			return dbMan.ExecuteReader(query);
		}
		public int InsertParticipate(int sid,int ac)
		{
			string query = "INSERT INTO Participate VALUES ('" + sid + "','" + ac + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable CourseStu()
		{
			string query = "SELECT distinct Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as StudentName,S.StudentID, CourseName  FROM Student S,Course C ,Takes R  Where s.StudentID=r.StudentID and c.CourseID=r.CourseID ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CourseStu(string name)
		{
			string query = "SELECT distinct Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as StudentName,S.StudentID FROM Student S,Course C ,Takes R  Where s.StudentID=r.StudentID and c.CourseID=r.CourseID and CourseName = '"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CourseCreditHours(string name)
		{
			string query = "Select distinct CreditHours from Course where coursename ='"+name+"'";
				return dbMan.ExecuteReader(query);
		}
		public DataTable CourseID(string name)
		{
			string query = "Select distinct CourseID from Course where coursename='"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CourseCreditHours()
		{
			string query = "Select CreditHours,CourseName from Course order by CourseName";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CourseID()
		{
			string query = "Select distinct CourseID from Course";
			return dbMan.ExecuteReader(query);
		}
		public DataTable ShowAllCourses()
		{
			string query = "Select CourseName,c.CourseID,CreditHours,Day,StartHour,EndHour,DepartmentName FROM COURSE c,Department d , BelongsTo b where b.CourseID=c.CourseID and d.DepartmentID=b.DepartmentID ";
			return dbMan.ExecuteReader(query);
		}
		public DataTable ShowAllCoursesbyname(string cname)
		{
			string query = "Select CourseName,c.CourseID,CreditHours,Day,StartHour,EndHour,DepartmentName FROM COURSE c,Department d , BelongsTo b where b.CourseID=c.CourseID and d.DepartmentID=b.DepartmentID and CourseName='"+cname+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable CourseName()
		{
			string query = "Select CourseName from Course";
			return dbMan.ExecuteReader(query);
		}
		public int InsertBelongsTo(int cid,int did)
		{
			string query = "INSERT INTO BelongsTo VALUES ('" + cid + "','" + did + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable CourseStuFilter(int id,string name)
		{
			string query = "SELECT distinct Trim(FName) +' ' +Minit + ' ' +Trim(Lname) as StudentName,S.StudentID,CourseName FROM Student S,Course C ,Takes R  Where s.StudentID=r.StudentID and c.CourseID=r.CourseID and s.StudentID ='"+id+"' AND CourseName = '"+name+"';";
			return dbMan.ExecuteReader(query);
		}
		public DataTable GetDay(string name)
		{
			string query = "select Day from course where CourseName = '"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable GetStart(string name)
		{
			string query = "select StartHour from course where CourseName = '" + name + "'";
			return dbMan.ExecuteReader(query);
		}
		public DataTable GetEnd(string name)
		{
			string query = "select endhour from course where CourseName = '" + name + "'";
			return dbMan.ExecuteReader(query);
		}
		public int DropCourse(int id, int cid)
		{
			string query = "Delete from Takes Where StudentID='"+id+"' And CourseID = '"+cid+"'";
			return dbMan.ExecuteNonQuery(query);
		}
		public int LeaveCourseInst(int id, int cid)
		{
			string query = "Delete from Teaches Where InstructorID='" + id + "' And CourseID = '" + cid + "'";
			return dbMan.ExecuteNonQuery(query);
		}
		public int DeleteInstructor(int id)
		{
			string query = "Delete from Instructor Where InstructorID = '"+id+"'";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable SelectCourseDep(string dname)
		{
			string query = " SELECT  distinct C.CourseID,CourseName,CreditHours,DepartmentName as Department FROM Takes T,Course C ,Department D , BelongsTo B Where  c.CourseID=b.CourseID AND b.DepartmentID=d.DepartmentID and departmentname = '"+dname+"' Order by C.CourseID";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Prerequisite()
		{
			string query = "SELECT c.CourseID,c.CourseName, R.PrerequisiteID ,p.CourseName As Prerequisite from course c, course p ,Prerequisite R where p.CourseID = r.PrerequisiteID and r.CourseID = c.CourseID";
			return dbMan.ExecuteReader(query);
		}
		public DataTable GetPrerequisiteID(string name)
		{
			string query = "select distinct CourseID as PreqID from course where CourseName='"+name+"'";
			return dbMan.ExecuteReader(query);
		}
		public int InsertInstructor(int id, string fname,char mi,string lname,string gender,int salary,string uname)
		{
			string query = "INSERT INTO INSTRUCTOR VALUES ('" + id + "', '" + fname + "','" + mi + "','" + lname + "','" + gender + "','" + salary + "','"+uname+"');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int InsertUser(string username)
		{
			string pass = "1234";
			string type = "Instr";
			string query = "INSERT INTO UserType VALUES ('" + username + "','" + pass + "','" + type + "')";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable InstructorCourse()
		{
			string query = "SELECT Trim(FirstName) +' ' +MiddleInt + ' ' +Trim(LastName) As InstructorName,I.InstructorID, C.CourseID,C.CourseName FROM COURSE C,INSTRUCTOR I,Teaches T " +
				"Where C.CourseID = T.CourseID and I.InstructorID = T.InstructorID";
			return dbMan.ExecuteReader(query);
		}
		public int InsertTeaches(int iid, int cid, int room, int level, string bname)
		{
			string query = "INSERT INTO Teaches VALUES ('" + iid + "', '" + cid + "','" + room + "'," + level + ",'" + bname + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable InstructorTable()
		{
			string query = "select * From Instructor";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Room()
		{
			string query = "select * From Room";
			return dbMan.ExecuteReader(query);
		}
		public int UpdateDepartment(string dname, int id, int mid)
		{
			string query = "UPDATE Department SET Mgr_ID= '"+mid+"' WHERE DepartmentID='"+id+"' and DepartmentName='"+dname+"'";
			return dbMan.ExecuteNonQuery(query);
		}
		public int DeleteDepartment(int id)
		{
			string query = "DELETE FROM Department WHERE DepartmentID='" + id + "';";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable Departments()
		{
			string query = "select * From Department";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Activity()
		{
			string query = "select * From Activity";
			return dbMan.ExecuteReader(query);
		}
		public DataTable Events()
		{
			string query = "select * From Event";
			return dbMan.ExecuteReader(query);
		}
		public DataTable SelectBnamefromid(int id)
		{
			string query = "select buildingname from building where buildingid='"+id+"'";
			return dbMan.ExecuteReader(query);
		}
		public int Pay(int pid, int amount, string year, int sid, DateTime date)
		{
			string query = "INSERT INTO FEES VALUES ('" + pid + "', '" + amount + "','" + year + "','" + sid + "','" + date.ToString("yyyy-MM-dd") + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddActivity(int pid, int amount, string year, int sid, DateTime date)
		{
			string query = "INSERT INTO FEES VALUES ('" + pid + "', '" + amount + "','" + year + "','" + sid + "','" + date.ToString("yyyy-MM-dd") + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddActivity(int pid, string type)
		{
			string query = "INSERT INTO Activity VALUES ('" + pid + "', '" + type + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddBuilding(string name, int bid)
		{
			string query = "INSERT INTO Building VALUES ('" + name + "', '" + bid + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddEvent(int eid, string name, DateTime sdate, DateTime edate)
		{
			string query = "INSERT INTO Event VALUES ('" +eid + "', '" + name + "','"+sdate+"','"+edate+"');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int AddRoom(int room, int level, int bid ,string name)
		{
			string query = "INSERT INTO Room VALUES ('" + room + "', '" + level + "','" + bid + "','" + name + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public int InsertGrade(int sid,int cid,char grade)
		{
			string query = "INSERT INTO Registered VALUES ('" + sid + "', '" + cid + "','" + grade + "');";
			return dbMan.ExecuteNonQuery(query);
		}
		public DataTable Welcome(int ID)
		{
			string query = "SELECT FirstName From Instructor where InstructorID = " + ID + " ";
			return dbMan.ExecuteReader(query);

		}
		public DataTable SelectAttendance()
		{
			string query = "SELECT * FROM Student_Attendance";
			return dbMan.ExecuteReader(query);
		}
		public DataTable getTimeTable(int id)
		{
			string query = "SELECT C.CourseID,C.Day,STARTHOUR,ENDHOUR,T.RoomNumber,T.LevelNumber,T.BuildingName, B.BuildingID " +
				"FROM Teaches as T,Course as C,Instructor as I, Building as B " +
				"WHERE T.InstructorID = " + id + " AND C.CourseID = T.CourseID AND T.InstructorID = I.InstructorID and B.BuildingName = T.BuildingName";
			return dbMan.ExecuteReader(query);
		}
		public void TerminateConnection()
		{
			dbMan.CloseConnection();
		}
	}
}
