using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
    class VaccineDetail
    {
        
        
            public int RegisterNo { get; set; }
            public VaccineType VaccinationType { get; set; }
            public int VaccinationDosage { get; set; }
            public DateTime VacinationTime { get; set; }
            public VaccineDetail(int registerNo, int vacinationType, int vaccinationDosage, DateTime vacinationTime)
            {
                this.RegisterNo = registerNo;
                this.VaccinationType = (VaccineType)vacinationType;
                this.VaccinationDosage = vaccinationDosage;
                this.VacinationTime = vacinationTime;
            }
            
            public enum VaccineType
            {
                Covishield,
                Covaccine,
                Spuknik
                
            }
            public static string GetVaccination(VaccineType VaccinationType)
            {
                switch (VaccinationType)
                {
                    case VaccineType.Covishield:
                        return "Others";
                    case VaccineType.Covaccine:
                        return "Covaccine";
                    case VaccineType.Spuknik:
                        return "Covishield";
                    default:
                        return "Invalid Data";
                }

            }
       
        }
    }

