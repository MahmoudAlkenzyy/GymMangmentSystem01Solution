using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class MemberShipConfigration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure ( EntityTypeBuilder<MemberShip> builder )
        {
            builder.HasKey ( x => x.Id );
            builder.Property ( x => x.StartDate ).HasDefaultValueSql ( "GetDate()" );
            builder.Property ( x => x.CreatedAt ).HasDefaultValueSql ( "GetDate()" );
            builder.HasOne ( x => x.Plan ).WithMany ( x => x.MemberShips ).HasForeignKey ( x => x.PlanId ).OnDelete ( DeleteBehavior.Restrict );

        }
    }
}
