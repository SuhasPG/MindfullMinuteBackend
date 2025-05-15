using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MindfullMinute.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class QuotesTableSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[,]
                {
                    { 1, "Thich Nhat Hanh", "The miracle is not to walk on water. The miracle is to walk on the green earth, dwelling in the present moment and feeling truly alive." },
                    { 2, "Amit Ray", "If you want to conquer the anxiety of life, live in the moment, live in the breath." },
                    { 3, "Eckhart Tolle", "The past has no power over the present moment." },
                    { 4, "Pema Chödrön", "To dwell in the here and now does not mean forgetting the past, but rather keeping it in its proper place—so that it enriches our present." },
                    { 5, "Buddha", "Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment." },
                    { 6, "Jon Kabat-Zinn", "Mindfulness means paying attention in a particular way: on purpose, in the present moment, and nonjudgmentally." },
                    { 7, "Gabrielle Bernstein", "You can never be fully present if your mind is occupied with past regrets or future anxieties. This moment is where life happens." },
                    { 8, "Unknown", "Be still. Let the silence speak to your soul. In stillness, we find clarity. In silence, we find peace. In silence, we find ourselves." },
                    { 9, "Lao Tzu", "We think too much, want too much, expect too much — and we fail to see the beauty right in front of us because we're always looking ahead." },
                    { 10, "Swami Muktananda", "When you do anything with complete awareness and deep attention, you are meditating. Whether you are walking, eating, or listening—be there fully." },
                    { 11, "Sarah Blondin", "Let go of the struggle to control everything. Trust the rhythm of life. Breathe deeply. Be present. Everything unfolds as it should." },
                    { 12, "Ralph Marston", "Don’t rush through life so fast that you forget not only where you’ve been, but also where you are going." },
                    { 13, "Osho", "Meditation is not a means to an end. It is the ultimate meditation when the meditator disappears completely and only meditation remains." },
                    { 14, "Vironika Tugaleva", "Your inner stillness becomes the space where miracles unfold. When you stop chasing and start being, the universe begins to conspire." },
                    { 15, "Buddha", "Every morning we are born again. What we do today matters most." },
                    { 16, "Thich Nhat Hanh", "Peace is available. Happiness is available. Even joy is available—at this very moment." },
                    { 17, "Sylvia Boorstein", "Feelings come and go like waves. Thoughts come and go like seagulls flying overhead. But beneath them all is the deep, calm ocean of your true self." },
                    { 18, "Ram Dass", "The quieter you become, the more you can hear. Listen not just with your ears, but with your heart. There is wisdom in silence." },
                    { 19, "Thich Nhat Hanh", "The art of mindfulness is the art of coming home to yourself. You are not behind, you are not ahead—you are simply here." },
                    { 20, "Alanis Morissette", "Breathe in deeply the way a flower drinks in the morning sun. Let each exhale release what no longer serves you. This is how you return to life." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
