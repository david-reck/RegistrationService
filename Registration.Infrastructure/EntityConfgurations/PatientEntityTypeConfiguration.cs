using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using iPAS.Services.Registration.Domain.AggregatesModel.PatientAggregate;
using iPAS.Services.Registration.Infrastructure;
using System;

namespace iPAS.Services.Registration.Infrastructure.EntityConfigurations
{
    class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> patientConfiguration)
        {
            patientConfiguration.ToTable("Patient", RegistrationContext.DEFAULT_SCHEMA);

            patientConfiguration.HasKey(o => o.PatientId);

            patientConfiguration.Ignore(b => b.DomainEvents);

            //patientConfiguration.Property(o => o.PatientId)
            //    .UseHiLo("orderseq", RegistrationContext.DEFAULT_SCHEMA);

            //Address value object persisted as owned entity type supported since EF Core 2.0
            patientConfiguration
                .OwnsOne(o => o.PatientAddress, a =>
                {
                    a.WithOwner();
                });

        patientConfiguration
                .Property<DateTime?>("BirthDate")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("BirthDate")
                .IsRequired(false);

        patientConfiguration
                .Property<string>("Gender")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Gender")
                .IsRequired(false);

        patientConfiguration
                    .Property<string>("FirstName")
                    .UsePropertyAccessMode(PropertyAccessMode.Field)
                    .HasColumnName("FirstName")
                    .IsRequired(false);

        patientConfiguration
                    .Property<string>("MiddleName")
                    .UsePropertyAccessMode(PropertyAccessMode.Field)
                    .HasColumnName("MiddleName")
                    .IsRequired(false);

        patientConfiguration
                    .Property<string>("LastName")
                    .UsePropertyAccessMode(PropertyAccessMode.Field)
                    .HasColumnName("LastName")
                    .IsRequired(false);

            //var navigation = patientConfiguration.Metadata.FindNavigation(nameof(Order.OrderItems));

            // DDD Patterns comment:
            //Set as field (New since EF 1.1) to access the OrderItem collection property through its field
            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
