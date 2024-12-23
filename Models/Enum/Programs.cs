using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Enum
{
    public enum Programs
    {
        [Display(Name = "Bachelor of Science in Information Technology")]
        BSIT,
        [Display(Name = "Bachelor of Science in Computer Science")]
        BSCS,
        [Display(Name = "Bachelor of Science in Business Administration")]
        BSBA,
        [Display(Name = "Bachelor of Science in Civil Engineering")]
        BSCE,
        [Display(Name = "Bachelor of Science in Electrical Engineering")]
        BSEE,
        [Display(Name = "Bachelor of Science in Accountancy")]
        BSA,
        [Display(Name = "Bachelor of Science in Psychology")]
        BSPsych,
        [Display(Name = "Bachelor of Science in Nursing")]
        BSN,
        [Display(Name = "Bachelor of Arts in Communication")]
        BAComm,
        [Display(Name = "Bachelor of Science in Education - Major in Mathematics")]
        BSEd_Math,
        [Display(Name = "Bachelor of Science in Education - Major in English")]
        BSEd_English,
        [Display(Name = "Bachelor of Science in Education - Major in Science")]
        BSEd_Science,
        [Display(Name = "Bachelor of Science in Agriculture")]
        BSAgriculture,
        [Display(Name = "Bachelor of Science in Tourism Management")]
        BSTM
    }
}
