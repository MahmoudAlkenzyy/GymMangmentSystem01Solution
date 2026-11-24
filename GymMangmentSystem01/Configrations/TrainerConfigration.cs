using GymMangmentSystem01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem01.Configrations
{
    public class TrainerConfigration : GymUserConfigration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure ( EntityTypeBuilder<Trainer> builder )

        {
            builder.Property ( x => x.CreatedAt ).HasColumnName ( "HireDate" ).HasDefaultValueSql ( "GetDate()" );
            base.Configure ( builder );
        }
    }
}
