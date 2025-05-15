using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MindfullMinute.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MindfullMinute.Infrastructure.Data
{
    public class AuthDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<JournalEntry> JournalEntries { get; set; }

        public DbSet<Streak> Streaks { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<JournalEntry>()
                .HasOne(j => j.User)
                .WithMany()
                .HasForeignKey(j => j.UserId);

            builder.Entity<Streak>()
                .HasOne(s=>s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId);


            builder.Entity<Quote>().HasData(
            new Quote { Id = 1, Text = "The miracle is not to walk on water. The miracle is to walk on the green earth, dwelling in the present moment and feeling truly alive.", Author = "Thich Nhat Hanh" },
            new Quote { Id = 2, Text = "If you want to conquer the anxiety of life, live in the moment, live in the breath.", Author = "Amit Ray" },
            new Quote { Id = 3, Text = "The past has no power over the present moment.", Author = "Eckhart Tolle" },
            new Quote { Id = 4, Text = "To dwell in the here and now does not mean forgetting the past, but rather keeping it in its proper place—so that it enriches our present.", Author = "Pema Chödrön" },
            new Quote { Id = 5, Text = "Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment.", Author = "Buddha" },
            new Quote { Id = 6, Text = "Mindfulness means paying attention in a particular way: on purpose, in the present moment, and nonjudgmentally.", Author = "Jon Kabat-Zinn" },
            new Quote { Id = 7, Text = "You can never be fully present if your mind is occupied with past regrets or future anxieties. This moment is where life happens.", Author = "Gabrielle Bernstein" },
            new Quote { Id = 8, Text = "Be still. Let the silence speak to your soul. In stillness, we find clarity. In silence, we find peace. In silence, we find ourselves.", Author = "Unknown" },
            new Quote { Id = 9, Text = "We think too much, want too much, expect too much — and we fail to see the beauty right in front of us because we're always looking ahead.", Author = "Lao Tzu" },
            new Quote { Id = 10, Text = "When you do anything with complete awareness and deep attention, you are meditating. Whether you are walking, eating, or listening—be there fully.", Author = "Swami Muktananda" },
            new Quote { Id = 11, Text = "Let go of the struggle to control everything. Trust the rhythm of life. Breathe deeply. Be present. Everything unfolds as it should.", Author = "Sarah Blondin" },
            new Quote { Id = 12, Text = "Don’t rush through life so fast that you forget not only where you’ve been, but also where you are going.", Author = "Ralph Marston" },
            new Quote { Id = 13, Text = "Meditation is not a means to an end. It is the ultimate meditation when the meditator disappears completely and only meditation remains.", Author = "Osho" },
            new Quote { Id = 14, Text = "Your inner stillness becomes the space where miracles unfold. When you stop chasing and start being, the universe begins to conspire.", Author = "Vironika Tugaleva" },
            new Quote { Id = 15, Text = "Every morning we are born again. What we do today matters most.", Author = "Buddha" },
            new Quote { Id = 16, Text = "Peace is available. Happiness is available. Even joy is available—at this very moment.", Author = "Thich Nhat Hanh" },
            new Quote { Id = 17, Text = "Feelings come and go like waves. Thoughts come and go like seagulls flying overhead. But beneath them all is the deep, calm ocean of your true self.", Author = "Sylvia Boorstein" },
            new Quote { Id = 18, Text = "The quieter you become, the more you can hear. Listen not just with your ears, but with your heart. There is wisdom in silence.", Author = "Ram Dass" },
            new Quote { Id = 19, Text = "The art of mindfulness is the art of coming home to yourself. You are not behind, you are not ahead—you are simply here.", Author = "Thich Nhat Hanh" },
            new Quote { Id = 20, Text = "Breathe in deeply the way a flower drinks in the morning sun. Let each exhale release what no longer serves you. This is how you return to life.", Author = "Alanis Morissette" }
        );
        }
    }
}
