using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HM.Data.Migrations
{
    public partial class InitializationDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    NIC = table.Column<int>(nullable: false),
                    Specialty = table.Column<string>(nullable: false),
                    Qualifications = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    NIC = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    TelephoneNo = table.Column<string>(nullable: false),
                    EmergencyContact = table.Column<string>(nullable: true),
                    BloodType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitingDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitingDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisLabTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(nullable: false),
                    LabTestId = table.Column<int>(nullable: true),
                    LabTest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisLabTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisLabTests_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisLabTests_LabTests_LabTestId",
                        column: x => x.LabTestId,
                        principalTable: "LabTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisMedicines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(nullable: false),
                    MedicineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisMedicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisMedicines_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisMedicines_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    DiagnosisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiagnoses_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisSymptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(nullable: false),
                    SymptomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisSymptoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisSymptoms_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisSymptoms_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorVisitingDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(nullable: false),
                    VisitingDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorVisitingDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorVisitingDates_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorVisitingDates_VisitingDates_VisitingDateId",
                        column: x => x.VisitingDateId,
                        principalTable: "VisitingDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisLabTests_DiagnosisId",
                table: "DiagnosisLabTests",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisLabTests_LabTestId",
                table: "DiagnosisLabTests",
                column: "LabTestId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisMedicines_DiagnosisId",
                table: "DiagnosisMedicines",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisMedicines_MedicineId",
                table: "DiagnosisMedicines",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisSymptoms_DiagnosisId",
                table: "DiagnosisSymptoms",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisSymptoms_SymptomId",
                table: "DiagnosisSymptoms",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_DoctorId",
                table: "DoctorPatients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorVisitingDates_DoctorId",
                table: "DoctorVisitingDates",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorVisitingDates_VisitingDateId",
                table: "DoctorVisitingDates",
                column: "VisitingDateId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_DiagnosisId",
                table: "PatientDiagnoses",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiagnoses_PatientId",
                table: "PatientDiagnoses",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosisLabTests");

            migrationBuilder.DropTable(
                name: "DiagnosisMedicines");

            migrationBuilder.DropTable(
                name: "DiagnosisSymptoms");

            migrationBuilder.DropTable(
                name: "DoctorPatients");

            migrationBuilder.DropTable(
                name: "DoctorVisitingDates");

            migrationBuilder.DropTable(
                name: "PatientDiagnoses");

            migrationBuilder.DropTable(
                name: "LabTests");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "VisitingDates");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
