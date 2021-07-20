using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _8058_Assignment_3.Models;

namespace _8058_Assignment_3.Controllers
{
   [RoutePrefix("api/Applicant")]
    public class ApplicantController : ApiController
    {
        // GET: Applicant
            public IEnumerable<Applicant> GetApplicantData() 
            {
                MyDBEntities1 context = new MyDBEntities1();
                IEnumerable<Applicant> applicantList = context.Applicants.ToList();
                return applicantList;
            }
            [HttpPost]
            public void CreateApplicant(Applicant applicant)
            {
                 MyDBEntities1 context = new MyDBEntities1();
                context.Applicants.Add(applicant);
                context.SaveChanges();

            }
        [HttpPut]
        public void UpdateApplicant(Applicant applicant, int id)
        {
            MyDBEntities1 context = new MyDBEntities1();
            Applicant updateApplicant = context.Applicants.Find(id);
            if (updateApplicant != null)
            {
                updateApplicant.ApplicantID = applicant.ApplicantID;
                updateApplicant.Password = applicant.Password;
                updateApplicant.Fname = applicant.Fname;
                updateApplicant.Mname = applicant.Mname;
                updateApplicant.LName = applicant.LName;
                updateApplicant.Skill = applicant.Skill;
                updateApplicant.Phone = applicant.Phone;
                updateApplicant.Address = applicant.Address;
                updateApplicant.Qualification = applicant.Qualification;
                updateApplicant.LastJobDescription = applicant.LastJobDescription;
                context.SaveChanges();
            }
        }
       [HttpDelete]
        public void DeleteApplicant(Applicant applicant, int id)
        {
            MyDBEntities1 context = new MyDBEntities1();
            Applicant deleteApplicant = context.Applicants.Find(id);
            if (deleteApplicant != null)
            {
                context.Applicants.Remove(deleteApplicant);
                context.SaveChanges();
            }

        }


    }
}