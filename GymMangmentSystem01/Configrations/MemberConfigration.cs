using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class MemberConfigration : GymUserConfigration<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure ( EntityTypeBuilder<Member> builder )
        {
            builder.Property ( x => x.CreatedAt ).HasColumnName ( "JoinDate" ).HasDefaultValueSql ( "GetDate()" );
            base.Configure ( builder );

        }
    }
}
