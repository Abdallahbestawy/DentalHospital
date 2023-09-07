using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalHospital.Services.Migrations
{
    public partial class InitCreateDesigner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChronicDiseases",
                columns: table => new
                {
                    chronicDiseasesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chronicDiseasesName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseases", x => x.chronicDiseasesId);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    clinicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clinicName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.clinicId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "ClinicDepartments",
                columns: table => new
                {
                    clinicDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clinicDepartmentName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    clinicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicDepartments", x => x.clinicDepartmentId);
                    table.ForeignKey(
                        name: "FK_ClinicDepartments_Clinics_clinicId",
                        column: x => x.clinicId,
                        principalTable: "Clinics",
                        principalColumn: "clinicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    doctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    clinicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.doctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_clinicId",
                        column: x => x.clinicId,
                        principalTable: "Clinics",
                        principalColumn: "clinicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternDoctor",
                columns: table => new
                {
                    internDoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternDoctor", x => x.internDoctorId);
                    table.ForeignKey(
                        name: "FK_InternDoctor_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    patientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.patientId);
                    table.ForeignKey(
                        name: "FK_Patients_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staffId);
                    table.ForeignKey(
                        name: "FK_Staff_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    diagnosisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    clinicId = table.Column<int>(type: "int", nullable: false),
                    interDoctorId = table.Column<int>(type: "int", nullable: false),
                    diagnosisStatus = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.diagnosisId);
                    table.ForeignKey(
                        name: "FK_Diagnosis_Clinics_clinicId",
                        column: x => x.clinicId,
                        principalTable: "Clinics",
                        principalColumn: "clinicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnosis_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "doctorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Diagnosis_InternDoctor_interDoctorId",
                        column: x => x.interDoctorId,
                        principalTable: "InternDoctor",
                        principalColumn: "internDoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnosis_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cashiers",
                columns: table => new
                {
                    cashierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    staffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashiers", x => x.cashierId);
                    table.ForeignKey(
                        name: "FK_Cashiers_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cashiers_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PatientChronicDiseases",
                columns: table => new
                {
                    patientChronicDiseasesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chronicDiseasesId = table.Column<int>(type: "int", nullable: false),
                    diagnosisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientChronicDiseases", x => x.patientChronicDiseasesId);
                    table.ForeignKey(
                        name: "FK_PatientChronicDiseases_ChronicDiseases_chronicDiseasesId",
                        column: x => x.chronicDiseasesId,
                        principalTable: "ChronicDiseases",
                        principalColumn: "chronicDiseasesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientChronicDiseases_Diagnosis_diagnosisId",
                        column: x => x.diagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "diagnosisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Radiologies",
                columns: table => new
                {
                    radiologyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    radiologyValue = table.Column<double>(type: "float", nullable: false),
                    typeRadiology = table.Column<int>(type: "int", nullable: false),
                    diagnosisId = table.Column<int>(type: "int", nullable: false),
                    staffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radiologies", x => x.radiologyId);
                    table.ForeignKey(
                        name: "FK_Radiologies_Diagnosis_diagnosisId",
                        column: x => x.diagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "diagnosisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Radiologies_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    sessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diagnosisId = table.Column<int>(type: "int", nullable: false),
                    internDoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.sessionId);
                    table.ForeignKey(
                        name: "FK_Session_Diagnosis_diagnosisId",
                        column: x => x.diagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "diagnosisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_InternDoctor_internDoctorId",
                        column: x => x.internDoctorId,
                        principalTable: "InternDoctor",
                        principalColumn: "internDoctorId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_patientId",
                table: "Cashiers",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_Cashiers_staffId",
                table: "Cashiers",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicDepartments_clinicId",
                table: "ClinicDepartments",
                column: "clinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_clinicId",
                table: "Diagnosis",
                column: "clinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_doctorId",
                table: "Diagnosis",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_interDoctorId",
                table: "Diagnosis",
                column: "interDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_patientId",
                table: "Diagnosis",
                column: "patientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_clinicId",
                table: "Doctors",
                column: "clinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_userId",
                table: "Doctors",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternDoctor_userId",
                table: "InternDoctor",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientChronicDiseases_chronicDiseasesId",
                table: "PatientChronicDiseases",
                column: "chronicDiseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientChronicDiseases_diagnosisId",
                table: "PatientChronicDiseases",
                column: "diagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_userId",
                table: "Patients",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Radiologies_diagnosisId",
                table: "Radiologies",
                column: "diagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Radiologies_staffId",
                table: "Radiologies",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_diagnosisId",
                table: "Session",
                column: "diagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_internDoctorId",
                table: "Session",
                column: "internDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_userId",
                table: "Staff",
                column: "userId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cashiers");

            migrationBuilder.DropTable(
                name: "ClinicDepartments");

            migrationBuilder.DropTable(
                name: "PatientChronicDiseases");

            migrationBuilder.DropTable(
                name: "Radiologies");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "ChronicDiseases");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "InternDoctor");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
