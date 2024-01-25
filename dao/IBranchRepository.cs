using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMangementConsole.entity;

namespace TrainingMangementConsole.dao
{
	internal interface IBranchRepository
	{
		public void GetAllBranches();
		public void GetBranchByID(int CollegeId);
		//public void InsertBranch(Branch branch);
	}
}
