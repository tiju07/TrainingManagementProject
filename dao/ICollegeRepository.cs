using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMangementConsole.entity;

namespace TrainingMangementConsole.dao
{
	public interface ICollegeRepository
	{
		public void GetAllColleges();
		public void GetCollegeByID(int CollegeId);
		public void InsertCollege(CollegeRepository college);
    }
}
