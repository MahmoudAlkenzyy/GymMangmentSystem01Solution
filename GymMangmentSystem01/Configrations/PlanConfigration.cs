using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class PlanConfigration : IEntityTypeConfiguration<Plan>
    {
        public void Configure ( EntityTypeBuilder<Plan> builder )
        {
            builder.Property ( x => x.CreatedAt ).HasDefaultValueSql ( "GetDate()" );
            builder.ToTable ( t =>
            {
                t.HasCheckConstraint ( "PlanDurationCheck" , "DurationDays between 0 and 365" );

            }
            );
        }
    }
}
