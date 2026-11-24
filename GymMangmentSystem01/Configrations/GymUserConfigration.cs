using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class GymUserConfigration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure ( EntityTypeBuilder<T> builder )
        {
            builder.Property ( x => x.Name ).HasColumnType ( "Varchar" ).HasMaxLength ( 50 );
            builder.Property ( x => x.Phone ).HasColumnType ( "VarChar" ).HasMaxLength ( 11 );
            builder.ComplexProperty ( x => x.Address );

            builder.HasIndex ( x => x.Email ).IsUnique ( );
            builder.HasIndex ( x => x.Phone ).IsUnique ( );

            builder.ToTable ( t =>
            {
                t.HasCheckConstraint ( "GymUser_EmailCheck" , "Email Like '_%@%.%'" );
                t.HasCheckConstraint ( "GymUser_PhoneCheck" , "LEN([Phone]) = 11 AND (Phone Like '010%' OR Phone Like '011%' OR Phone Like '012%' OR Phone Like '015%' ) " );
            }
            );


        }
    }
}
