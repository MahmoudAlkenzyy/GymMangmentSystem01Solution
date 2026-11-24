using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class SessionConfigration : IEntityTypeConfiguration<Session>
    {
        public void Configure ( EntityTypeBuilder<Session> builder )
        {
            builder.Property ( x => x.CreatedAt ).HasDefaultValueSql ( "GetDate()" );
            builder.HasOne ( x => x.Trainer ).WithMany ( x => x.Sessions ).OnDelete ( DeleteBehavior.Restrict );
            builder.ToTable ( t =>
            {
                t.HasCheckConstraint ( "SessionCapacityCheck" , "Capacity between 1 and 25" );
                t.HasCheckConstraint ( "SessionTimeCheck" , "StartTime < EndTime" );
            }
            );
        }
    }
}
