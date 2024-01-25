using TrainingMangementConsole.dao;
using TrainingMangementConsole.util;

Console.WriteLine(DBConn.connString);

CollegeRepository collegeRepository = new CollegeRepository();
collegeRepository.GetAllColleges();