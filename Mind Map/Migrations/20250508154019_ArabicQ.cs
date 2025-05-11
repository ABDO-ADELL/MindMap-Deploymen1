using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mind_Map.Migrations
{
    /// <inheritdoc />
    public partial class ArabicQ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات الاكتئاب", "تشير إجاباتك إلى احتمال وجود اكتئاب. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - الاكتئاب - النموذج المختصر واستشارة أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "مشاكل متعلقة بالغضب", "تشير إجاباتك إلى وجود مشاكل محتملة في الغضب. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - الغضب - النموذج المختصر واستشارة أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب ثنائي القطب أو نوبات الهوس", "تشير إجاباتك إلى احتمال وجود أعراض هوسية. يُنصح باستخدام مقياس التقييم الذاتي لهوس ألتمن واستشارة أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات القلق", "تشير إجاباتك إلى احتمال وجود قلق. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - القلق - النموذج المختصر واستشارة أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات الأعراض الجسدية", "تشير إجاباتك إلى أعراض جسدية قد تكون مرتبطة بالتوتر. يُنصح باستخدام استبيان صحة المريض 15 (PHQ-15) واستشارة أخصائي طبي." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "أفكار انتحارية", "عاجل: تشير إجاباتك إلى أفكار إيذاء النفس. يرجى الاتصال بأخصائي صحة نفسية أو خط الأزمة فوراً." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات ذهانية", "عاجل: تشير إجاباتك إلى أعراض ذهانية محتملة. يرجى استشارة أخصائي صحة نفسية فوراً." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات النوم", "تشير إجاباتك إلى صعوبات في النوم. يُنصح بالنظر في نموذج PROMIS للاضطرابات النوم - النموذج المختصر واستشارة أخصائي نوم أو أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "ضعف إدراكي", "تشير إجاباتك إلى مشاكل في الذاكرة. يُنصح باستشارة طبيب أعصاب أو أخصائي صحة نفسية لإجراء تقييم إدراكي." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب الوسواس القهري (OCD)", "تشير إجاباتك إلى احتمال وجود اضطراب الوسواس القهري. يُنصح باستخدام مقياس شدة فلويدا للوسواس القهري (FOCI) واستشارة أخصائي صحة نفسية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات انفصام الشخصية", "تشير إجاباتك إلى احتمال وجود انفصال نفسي. يُنصح باستشارة أخصائي صحة نفسية لتقييم متخصص." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات الشخصية", "تشير إجاباتك إلى تحديات في الهوية أو العلاقات. يُنصح باستشارة أخصائي صحة نفسية لتقييم الشخصية." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات تعاطي المواد", "تشير إجاباتك إلى احتمال سوء استخدام المواد. يُنصح باستخدام ASSIST المعدل من NIDA واستشارة أخصائي تعاطي المخدرات." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات القلق", "تشير إجاباتك إلى أعراض قلق كبيرة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب ثنائي القطب أو نوبات الهوس", "تشير إجاباتك إلى احتمال عالي لأعراض الهوس. يُنصح باستشارة أخصائي صحة نفسية فوراً." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب الوسواس القهري (OCD)", "تشير إجاباتك إلى أعراض وسواس قهري كبيرة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب ما بعد الصدمة", "تشير إجاباتك إلى أعراض كبيرة لاضطراب ما بعد الصدمة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطرابات ذهانية", "تشير إجاباتك إلى أعراض ذهانية محتملة. يُنصح باستشارة أخصائي صحة نفسية فوراً." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "اضطراب نقص الانتباه مع فرط النشاط", "تشير إجاباتك إلى أعراض محتملة لاضطراب نقص الانتباه مع فرط النشاط. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم." });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "تصف الميل إلى الاجتماعي مقابل التحفظ", "الانفتاح" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "التركيز على الأنماط مقابل الحقائق", "الحدس" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "المنطق مقابل التعاطف", "التفكير" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "التفضيل نحو النظام مقابل العفوية", "الحكم" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "الثقة بالنفس مقابل الحساسية", "الحزم" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "قلة الاهتمام أو المتعة في القيام بالأشياء؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "الشعور بالحزن أو الاكتئاب أو اليأس؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "الشعور بمزيد من التهيج أو الغضب أكثر من المعتاد؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Text",
                value: "النوم أقل من المعتاد، ولكن لا تزال تملك الكثير من الطاقة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "بدء المزيد من المشاريع من المعتاد أو القيام بأشياء أكثر خطورة من المعتاد؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Text",
                value: "الشعور بالتوتر أو القلق أو الخوف أو القلق أو التوتر؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "الشعور بنوبات هلع أو الخوف؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "تجنب المواقف التي تجعلك تشعر بالقلق؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Text",
                value: "آلام وأوجاع غير مفسرة (مثل الرأس، الظهر، المفاصل، البطن، الساقين)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Text",
                value: "الشعور بأن أمراضك لا تؤخذ على محمل الجد بما فيه الكفاية؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Text",
                value: "أفكار عن إيذاء نفسك؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Text",
                value: "سماع أشياء لا يستطيع الآخرون سماعها، مثل الأصوات حتى عندما لا يكون هناك أحد؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Text",
                value: "الشعور بأن شخصاً ما يمكنه سماع أفكارك، أو أنك تستطيع سماع ما يفكر به شخص آخر؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Text",
                value: "مشاكل في النوم أثرت على جودة نومك بشكل عام؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Text",
                value: "مشاكل في الذاكرة (مثل تعلم معلومات جديدة) أو في المكان (مثل إيجاد طريقك إلى المنزل)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Text",
                value: "أفكار أو رغبات أو صور غير سارة تدخل ذهنك مرارًا وتكرارًا؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Text",
                value: "الشعور بأنك مدفوع لأداء سلوكيات أو أعمال ذهنية معينة مرارًا وتكرارًا؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Text",
                value: "الشعور بالانفصال أو البعد عن نفسك، جسدك، محيطك المادي، أو ذكرياتك؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Text",
                value: "عدم معرفة من أنت حقًا أو ما تريد من الحياة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Text",
                value: "عدم الشعور بالقرب من الآخرين أو الاستمتاع بعلاقاتك معهم؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Text",
                value: "شرب 4 مشروبات كحولية على الأقل في يوم واحد؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Text",
                value: "تدخين أي سجائر أو سيجار أو غليون، أو استخدام السعوط أو مضغ التبغ؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Text",
                value: "استخدام أي من الأدوية التالية بمفردك، أي بدون وصفة طبية، بجرعات أكبر أو لفترة أطول من الموصوفة [مثل مسكنات الألم (مثل فيكودين)، المنشطات (مثل ريتالين أو أدرال)، المهدئات أو المهدئات (مثل حبوب النوم أو فاليم)، أو المخدرات مثل الماريجوانا، الكوكايين أو الكراك، مخدرات النوادي (مثل الإكستاسي)، الهلوسة (مثل LSD)، الهيروين، الاستنشاق أو المذيبات (مثل الغراء)، أو الميثامفيتامين (مثل السريع)]؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Text",
                value: "شعرت بالخوف.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Text",
                value: "شعرت بالقلق.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Text",
                value: "شعرت بالهم.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Text",
                value: "وجدت صعوبة في التركيز على أي شيء غير قلقي.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Text",
                value: "شعرت بالتوتر.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Text",
                value: "شعرت بعدم الارتياح.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Text",
                value: "شعرت بالتوتر الشديد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Text",
                value: "الشعور بسعادة أو بهجة أكثر من المعتاد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Text",
                value: "الشعور بثقة بالنفس أكثر من المعتاد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Text",
                value: "الحاجة إلى نوم أقل من المعتاد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Text",
                value: "التحدث أكثر من المعتاد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Text",
                value: "أن تكون أكثر نشاطاً (اجتماعياً، جنسياً، في العمل، المنزل، أو المدرسة) من المعتاد.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Text",
                value: "كم من الوقت يشغلك في المتوسط هذه الأفكار أو السلوكيات يومياً؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Text",
                value: "ما مدى الضيق الذي تسببه لك هذه الأفكار أو السلوكيات؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Text",
                value: "ما مدى صعوبة التحكم في هذه الأفكار أو السلوكيات؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Text",
                value: "ما مدى تسبب هذه الأفكار أو السلوكيات في تجنبك القيام بأي شيء، أو الذهاب إلى أي مكان، أو التواجد مع أي شخص؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Text",
                value: "ما مدى تأثير هذه الأفكار أو السلوكيات على دراستك أو عملك أو حياتك الاجتماعية أو العائلية؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Text",
                value: "ذكريات متكررة ومزعجة وغير مرغوب فيها للتجربة المجهدة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Text",
                value: "أحلام متكررة ومزعجة عن التجربة المجهدة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Text",
                value: "الشعور فجأة أو التصرف كما لو أن التجربة المجهدة تحدث مرة أخرى (كما لو كنت تعيشها فعلاً مرة أخرى)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Text",
                value: "الشعور بالانزعاج الشديد عندما يذكرك شيء بالتجربة المجهدة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Text",
                value: "وجود ردود فعل جسدية قوية عندما يذكرك شيء بالتجربة المجهدة (مثل خفقان القلب، صعوبة في التنفس، التعرق)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Text",
                value: "تجنب الذكريات أو الأفكار أو المشاعر المتعلقة بالتجربة المجهدة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Text",
                value: "تجنب المثيرات الخارجية التي تذكرك بالتجربة المجهدة (مثل الأشخاص، الأماكن، المحادثات، الأنشطة، الأشياء، أو المواقف)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Text",
                value: "صعوبة في تذكر أجزاء مهمة من التجربة المجهدة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Text",
                value: "وجود معتقدات سلبية قوية عن نفسك أو الآخرين أو العالم (مثل أفكار: أنا سيء، هناك شيء خطير خاطئ بي، لا يمكن الوثوق بأحد، العالم خطير تماماً)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Text",
                value: "لوم نفسك أو شخص آخر على التجربة المجهدة أو ما حدث بعدها؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Text",
                value: "وجود مشاعر سلبية قوية مثل الخوف، الرعب، الغضب، الذنب، أو الخجل؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Text",
                value: "فقدان الاهتمام بالأنشطة التي كنت تستمتع بها؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Text",
                value: "الشعور بالبعد أو الانفصال عن الآخرين؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Text",
                value: "صعوبة في تجربة المشاعر الإيجابية (مثل عدم القدرة على الشعور بالسعادة أو الحب تجاه الأشخاص المقربين)؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Text",
                value: "سلوك سريع الغضب، نوبات غضب، أو التصرف بعدوانية؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Text",
                value: "المخاطرة المفرطة أو القيام بأشياء قد تسبب لك الأذى؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Text",
                value: "كونك 'متيقظاً جداً' أو مراقباً أو في حالة حذر؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Text",
                value: "الشعور بالتوتر أو القفز بسهولة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Text",
                value: "صعوبة في التركيز؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Text",
                value: "صعوبة في النوم أو البقاء نائماً؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Text",
                value: "الهلاوس");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Text",
                value: "الأوهام");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Text",
                value: "الكلام غير المنظم");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Text",
                value: "السلوك النفسي الحركي الشاذ");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Text",
                value: "الأعراض السلبية (تعبير عاطفي محدود أو انعدام الدافع)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Text",
                value: "الاضطراب المعرفي");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Text",
                value: "الاكتئاب");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Text",
                value: "الجنون");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Text",
                value: "كم مرة تواجه صعوبة في إنهاء التفاصيل النهائية لمشروع، بعد أن يتم إنجاز الأجزاء الصعبة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Text",
                value: "كم مرة تواجه صعوبة في ترتيب الأشياء عندما يتعين عليك أداء مهمة تتطلب التنظيم؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Text",
                value: "كم مرة تواجه صعوبة في تذكر المواعيد أو الالتزامات؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Text",
                value: "عندما يكون لديك مهمة تتطلب الكثير من التفكير، كم مرة تتجنب أو تؤجل البدء بها؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Text",
                value: "كم مرة تتحرك أو تزعج يديك أو قدميك عندما يتعين عليك الجلوس لفترة طويلة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Text",
                value: "كم مرة تشعر بالنشاط المفرط وترغب في القيام بالأشياء، وكأنك مدفوع بمحرك؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Text",
                value: "كم مرة ترتكب أخطاء غير مبالية عندما يتعين عليك العمل على مشروع ممل أو صعب؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Text",
                value: "كم مرة تجد صعوبة في الحفاظ على انتباهك عندما تقوم بعمل ممل أو متكرر؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Text",
                value: "كم مرة تجد صعوبة في التركيز على ما يقوله الناس لك، حتى عندما يتحدثون إليك مباشرة؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Text",
                value: "كم مرة تضع أو تجد صعوبة في العثور على الأشياء في المنزل أو في العمل؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Text",
                value: "كم مرة يتم تشتيتك بسبب النشاط أو الضوضاء من حولك؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Text",
                value: "كم مرة تغادر مقعدك في الاجتماعات أو في المواقف التي يُتوقع منك البقاء جالسًا فيها؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Text",
                value: "كم مرة تشعر بالقلق أو التململ؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Text",
                value: "كم مرة تجد صعوبة في الاسترخاء عندما يكون لديك وقت لنفسك؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Text",
                value: "كم مرة تجد نفسك تتحدث كثيرًا عندما تكون في مواقف اجتماعية؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Text",
                value: "عندما تكون في محادثة، كم مرة تجد نفسك تكمل جمل الأشخاص الذين تتحدث معهم قبل أن يتمكنوا من إتمامها بأنفسهم؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Text",
                value: "كم مرة تجد صعوبة في الانتظار لدورك في المواقف التي يتطلب فيها أخذ الدور؟");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Text",
                value: "كم مرة تقاطع الآخرين عندما يكونون مشغولين؟");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 87,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 88,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 89,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 90,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 92,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 96,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 98,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 99,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 101,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 102,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 104,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 107,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "لا شيء / لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "طفيف / نادر، أقل من يوم أو يومين");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "خفيف / عدة أيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Description",
                value: "متوسط / أكثر من نصف الأيام");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "شديد / تقريباً كل يوم");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 119,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 120,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 121,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 123,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 126,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 127,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 132,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 138,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 140,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 141,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 146,
                column: "Description",
                value: "أبداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 148,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 149,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 150,
                column: "Description",
                value: "دائماً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 151,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 152,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 153,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 154,
                column: "Description",
                value: "كثيراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 155,
                column: "Description",
                value: "طوال الوقت");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 156,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 157,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 158,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 159,
                column: "Description",
                value: "كثيراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "طوال الوقت");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 161,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 162,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 163,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "كثيراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 165,
                column: "Description",
                value: "طوال الوقت");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 167,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 168,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 169,
                column: "Description",
                value: "كثيراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 170,
                column: "Description",
                value: "طوال الوقت");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 172,
                column: "Description",
                value: "أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 173,
                column: "Description",
                value: "غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 174,
                column: "Description",
                value: "كثيراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 175,
                column: "Description",
                value: "طوال الوقت");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 176,
                column: "Description",
                value: "لا شيء");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 177,
                column: "Description",
                value: "خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 178,
                column: "Description",
                value: "متوسط");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 179,
                column: "Description",
                value: "شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 180,
                column: "Description",
                value: "شديد جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "لا شيء");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 183,
                column: "Description",
                value: "متوسط");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 185,
                column: "Description",
                value: "شديد جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "لا شيء");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 187,
                column: "Description",
                value: "خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "متوسط");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 189,
                column: "Description",
                value: "شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 190,
                column: "Description",
                value: "شديد جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "لا شيء");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 192,
                column: "Description",
                value: "خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 193,
                column: "Description",
                value: "متوسط");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 195,
                column: "Description",
                value: "شديد جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 196,
                column: "Description",
                value: "لا شيء");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 197,
                column: "Description",
                value: "خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 198,
                column: "Description",
                value: "متوسط");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 199,
                column: "Description",
                value: "شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 200,
                column: "Description",
                value: "شديد جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 201,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 202,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 203,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 204,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 205,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 206,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 207,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 208,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 209,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 210,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 211,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 212,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 213,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 214,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 215,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 216,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 217,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 218,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 219,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 220,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 221,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 222,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 223,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 224,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 225,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 226,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 227,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 228,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 229,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 230,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 231,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 232,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 233,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 234,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 235,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 236,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 237,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 238,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 239,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 240,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 241,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 242,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 243,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 244,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 245,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 246,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 247,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 248,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 249,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 250,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 251,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 252,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 253,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 254,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 255,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 256,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 257,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 258,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 259,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 260,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 261,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 262,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 263,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 264,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 265,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 266,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 267,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 268,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 269,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 270,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 271,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 272,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 273,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 274,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 275,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 276,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 277,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 278,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 279,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 280,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 281,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 282,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 283,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 284,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 285,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 286,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 287,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 288,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 289,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 290,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 291,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 292,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 293,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 294,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 295,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 296,
                column: "Description",
                value: "لا على الإطلاق");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 297,
                column: "Description",
                value: "قليلاً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 298,
                column: "Description",
                value: "بشكل معتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 299,
                column: "Description",
                value: "إلى حد كبير");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 300,
                column: "Description",
                value: "بشكل شديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 301,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 302,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 303,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 304,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 305,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 306,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 307,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 308,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 309,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 310,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 311,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 312,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 313,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 314,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 315,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 316,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 317,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 318,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 319,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 320,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 321,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 322,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 323,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 324,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 325,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 326,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 327,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 328,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 329,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 330,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 331,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 332,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 333,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 334,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 335,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 336,
                column: "Description",
                value: "غير موجود");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 337,
                column: "Description",
                value: "غير واضح");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 338,
                column: "Description",
                value: "موجود، ولكن خفيف");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 339,
                column: "Description",
                value: "موجود ومعتدل");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 340,
                column: "Description",
                value: "موجود وشديد");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 341,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 342,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 343,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 344,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 345,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 346,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 347,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 348,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 349,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 350,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 351,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 352,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 353,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 354,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 355,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 356,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 357,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 358,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 359,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 360,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 361,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 362,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 363,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 364,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 365,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 366,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 367,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 368,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 369,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 370,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 371,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 372,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 373,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 374,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 375,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 376,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 377,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 378,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 379,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 380,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 381,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 382,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 383,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 384,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 385,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 386,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 387,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 388,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 389,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 390,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 391,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 392,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 393,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 394,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 395,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 396,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 397,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 398,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 399,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 400,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 401,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 402,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 403,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 404,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 405,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 406,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 407,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 408,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 409,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 410,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 411,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 412,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 413,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 414,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 415,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 416,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 417,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 418,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 419,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 420,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 421,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 422,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 423,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 424,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 425,
                column: "Description",
                value: "كثيراً جداً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 426,
                column: "Description",
                value: "أبدًا");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 427,
                column: "Description",
                value: "نادراً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 428,
                column: "Description",
                value: " أحياناً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 429,
                column: "Description",
                value: " غالباً");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 430,
                column: "Description",
                value: "كثيراً جداً");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Depressive Disorders", "Your responses suggest possible depression. Consider the PROMIS Emotional Distress—Depression—Short Form and consult a mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Anger-Related Issues", "Your responses indicate potential anger issues. Consider the PROMIS Emotional Distress—Anger—Short Form and consult a mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Bipolar Disorder or Manic Episodes", "Your responses suggest possible manic symptoms. Consider the Altman Self-Rating Mania Scale and consult a mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Anxiety Disorders", "Your responses indicate possible anxiety. Consider the PROMIS Emotional Distress—Anxiety—Short Form and consult a mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Somatic Symptom Disorders", "Your responses suggest physical symptoms that may be stress-related. Consider the Patient Health Questionnaire 15 (PHQ-15) and consult a medical professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Suicidal Ideation", "Urgent: Your responses indicate thoughts of self-harm. Please contact a mental health professional or crisis hotline immediately." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Psychotic Disorders", "Urgent: Your responses suggest possible psychotic symptoms. Please consult a mental health professional immediately." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Sleep Disorders", "Your responses indicate sleep difficulties. Consider the PROMIS—Sleep Disturbance—Short Form and consult a sleep specialist or mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Cognitive Impairment", "Your responses suggest memory issues. Consult a neurologist or mental health professional for a cognitive assessment." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Obsessive-Compulsive Disorder (OCD)", "Your responses suggest possible OCD. Consider the Florida Obsessive-Compulsive Inventory (FOCI) Severity Scale and consult a mental health professional." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Dissociative Disorders", "Your responses indicate possible dissociation. Consult a mental health professional for a specialized assessment." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Personality Disorders", "Your responses suggest challenges with identity or relationships. Consult a mental health professional for a personality assessment." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Substance Use Disorders", "Your responses indicate possible substance misuse. Consider the NIDA-modified ASSIST and consult a substance abuse specialist." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Anxiety Disorders", "Your responses indicate significant anxiety symptoms. Consult a mental health professional for further evaluation." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Bipolar Disorder or Manic Episodes", "Your responses suggest a high probability of manic symptoms. Consult a mental health professional immediately." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Obsessive-Compulsive Disorder (OCD)", "Your responses suggest significant OCD symptoms. Consult a mental health professional for further evaluation." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Post-Traumatic Stress Disorder", "Your responses indicate significant PTSD symptoms. Consult a mental health professional for further evaluation." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Psychotic Disorders", "Your responses suggest possible psychotic symptoms. Consult a mental health professional immediately." });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PotentialDisorder", "Recommendation" },
                values: new object[] { "Attention-Deficit/Hyperactivity Disorder", "Your responses suggest possible ADHD symptoms. Consult a mental health professional for further evaluation." });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Describes sociability vs. reservedness", "Extraversion" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Focus on patterns vs. facts", "Intuition" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Logic vs. empathy", "Thinking" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Preference for order vs. spontaneity", "Judging" });

            migrationBuilder.UpdateData(
                table: "PersonalityTraits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Self-assurance vs. sensitivity", "Assertiveness" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Little interest or pleasure in doing things?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "Feeling down, depressed, or hopeless?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "Feeling more irritated, grouchy, or angry than usual?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Text",
                value: "Sleeping less than usual, but still have a lot of energy?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "Starting lots more projects than usual or doing more risky things than usual?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Text",
                value: "Feeling nervous, anxious, frightened, worried, or on edge?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "Feeling panic or being frightened?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "Avoiding situations that make you anxious?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Text",
                value: "Unexplained aches and pains (e.g., head, back, joints, abdomen, legs)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Text",
                value: "Feeling that your illnesses are not being taken seriously enough?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Text",
                value: "Thoughts of actually hurting yourself?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Text",
                value: "Hearing things other people couldn’t hear, such as voices even when no one was around?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Text",
                value: "Feeling that someone could hear your thoughts, or that you could hear what another person was thinking?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Text",
                value: "Problems with sleep that affected your sleep quality over all?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Text",
                value: "Problems with memory (e.g., learning new information) or with location (e.g., finding your way home)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Text",
                value: "Unpleasant thoughts, urges, or images that repeatedly enter your mind?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Text",
                value: "Feeling driven to perform certain behaviors or mental acts over and over again?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Text",
                value: "Feeling detached or distant from yourself, your body, your physical surroundings, or your memories?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Text",
                value: "Not knowing who you really are or what you want out of life?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Text",
                value: "Not feeling close to other people or enjoying your relationships with them?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Text",
                value: "Drinking at least 4 drinks of any kind of alcohol in a single day?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Text",
                value: "Smoking any cigarettes, a cigar, or pipe, or using snuff or chewing tobacco?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Text",
                value: "Using any of the following medicines ON YOUR OWN, that is, without a doctor’s prescription, in greater amounts or longer than prescribed [e.g., painkillers (like Vicodin), stimulants (like Ritalin or Adderall), sedatives or tranquilizers (like sleeping pills or Valium), or drugs like marijuana, cocaine or crack, club drugs (like ecstasy), hallucinogens (like LSD), heroin, inhalants or solvents (like glue), or methamphetamine (like speed)]?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Text",
                value: "I felt fearful.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Text",
                value: "I felt anxious.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Text",
                value: "I felt worried.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Text",
                value: "I found it hard to focus on anything other than my anxiety.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Text",
                value: "I felt nervous.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Text",
                value: "I felt uneasy.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Text",
                value: "I felt tense.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Text",
                value: "Feel happier or more cheerful than usual.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Text",
                value: "Feel more self-confident than usual.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Text",
                value: "Need less sleep than usual.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Text",
                value: "Talk more than usual.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Text",
                value: "Been more active (either socially, sexually, at work, home, or school) than usual.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Text",
                value: "On average, how much time is occupied by these thoughts or behaviors each day?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Text",
                value: "How much distress do these thoughts or behaviors cause you?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Text",
                value: "How hard is it for you to control these thoughts or behaviors?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Text",
                value: "How much do these thoughts or behaviors cause you to avoid doing anything, going anyplace, or being with anyone?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Text",
                value: "How much do these thoughts or behaviors interfere with school, work, or your social or family life?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Text",
                value: "Repeated, disturbing, and unwanted memories of the stressful experience?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Text",
                value: "Repeated, disturbing dreams of the stressful experience?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Text",
                value: "Suddenly feeling or acting as if the stressful experience were actually happening again (as if you were actually back there reliving it)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Text",
                value: "Feeling very upset when something reminded you of the stressful experience?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Text",
                value: "Having strong physical reactions when something reminded you of the stressful experience (for example, heart pounding, trouble breathing, sweating)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Text",
                value: "Avoiding memories, thoughts, or feelings related to the stressful experience?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Text",
                value: "Avoiding external reminders of the stressful experience (for example, people, places, conversations, activities, objects, or situations)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Text",
                value: "Trouble remembering important parts of the stressful experience?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Text",
                value: "Having strong negative beliefs about yourself, other people, or the world (for example, having thoughts such as: I am bad, there is something seriously wrong with me, no one can be trusted, the world is completely dangerous)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Text",
                value: "Blaming yourself or someone else for the stressful experience or what happened after it?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Text",
                value: "Having strong negative feelings such as fear, horror, anger, guilt, or shame?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Text",
                value: "Loss of interest in activities that you used to enjoy?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Text",
                value: "Feeling distant or cut off from other people?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Text",
                value: "Trouble experiencing positive feelings (for example, being unable to feel happiness or have loving feelings for people close to you)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Text",
                value: "Irritable behavior, angry outbursts, or acting aggressively?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Text",
                value: "Taking too many risks or doing things that could cause you harm?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Text",
                value: "Being 'superalert' or watchful or on guard?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Text",
                value: "Feeling jumpy or easily startled?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Text",
                value: "Having difficulty concentrating?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Text",
                value: "Trouble falling or staying asleep?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Text",
                value: "Hallucinations");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Text",
                value: "Delusions");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Text",
                value: "Disorganized speech");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Text",
                value: "Abnormal psychomotor behavior");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Text",
                value: "Negative symptoms (restricted emotional expression or avolition)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Text",
                value: "Impaired cognition");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Text",
                value: "Depression");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Text",
                value: "Mania");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Text",
                value: "How often do you have trouble wrapping up the final details of a project, once the challenging parts have been done?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Text",
                value: "How often do you have difficulty getting things in order when you have to do a task that requires organization?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Text",
                value: "How often do you have problems remembering appointments or obligations?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Text",
                value: "When you have a task that requires a lot of thought, how often do you avoid or delay getting started?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Text",
                value: "How often do you fidget or squirm with your hands or feet when you have to sit down for a long time?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Text",
                value: "How often do you feel overly active and compelled to do things, like you were driven by a motor?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Text",
                value: "How often do you make careless mistakes when you have to work on a boring or difficult project?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Text",
                value: "How often do you have difficulty keeping your attention when you are doing boring or repetitive work?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Text",
                value: "How often do you have difficulty concentrating on what people say to you, even when they are speaking to you directly?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Text",
                value: "How often do you misplace or have difficulty finding things at home or at work?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Text",
                value: "How often are you distracted by activity or noise around you?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Text",
                value: "How often do you leave your seat in meetings or other situations in which you are expected to remain seated?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Text",
                value: "How often do you feel restless or fidgety?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Text",
                value: "How often do you have difficulty unwinding and relaxing when you have time to yourself?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Text",
                value: "How often do you find yourself talking too much when you are in social situations?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Text",
                value: "When you're in a conversation, how often do you find yourself finishing the sentences of the people you are talking to, before they can finish them themselves?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Text",
                value: "How often do you have difficulty waiting your turn in situations when turn taking is required?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Text",
                value: "How often do you interrupt others when they are busy?");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 76,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 80,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 81,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 85,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 87,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 88,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 89,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 90,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 91,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 92,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 96,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 97,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 98,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 99,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 101,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 102,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 104,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 107,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 108,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "None/Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "Slight/Rare, less than a day or two");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "Mild/Several days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Description",
                value: "Moderate/More than half the days");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "Severe/Nearly every day");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 119,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 120,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 121,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 123,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 126,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 127,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 132,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 138,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 140,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 141,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 146,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 148,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 149,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 150,
                column: "Description",
                value: "Always");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 151,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 152,
                column: "Description",
                value: "Occasionally");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 153,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 154,
                column: "Description",
                value: "Frequently");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 155,
                column: "Description",
                value: "All the time");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 156,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 157,
                column: "Description",
                value: "Occasionally");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 158,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 159,
                column: "Description",
                value: "Frequently");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "All the time");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 161,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 162,
                column: "Description",
                value: "Occasionally");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 163,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "Frequently");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 165,
                column: "Description",
                value: "All the time");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 167,
                column: "Description",
                value: "Occasionally");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 168,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 169,
                column: "Description",
                value: "Frequently");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 170,
                column: "Description",
                value: "All the time");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 172,
                column: "Description",
                value: "Occasionally");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 173,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 174,
                column: "Description",
                value: "Frequently");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 175,
                column: "Description",
                value: "All the time");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 176,
                column: "Description",
                value: "None");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 177,
                column: "Description",
                value: "Mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 178,
                column: "Description",
                value: "Moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 179,
                column: "Description",
                value: "Severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 180,
                column: "Description",
                value: "Extreme");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "None");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "Mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 183,
                column: "Description",
                value: "Moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "Severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 185,
                column: "Description",
                value: "Extreme");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "None");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 187,
                column: "Description",
                value: "Mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "Moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 189,
                column: "Description",
                value: "Severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 190,
                column: "Description",
                value: "Extreme");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "None");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 192,
                column: "Description",
                value: "Mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 193,
                column: "Description",
                value: "Moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "Severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 195,
                column: "Description",
                value: "Extreme");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 196,
                column: "Description",
                value: "None");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 197,
                column: "Description",
                value: "Mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 198,
                column: "Description",
                value: "Moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 199,
                column: "Description",
                value: "Severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 200,
                column: "Description",
                value: "Extreme");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 201,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 202,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 203,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 204,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 205,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 206,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 207,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 208,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 209,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 210,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 211,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 212,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 213,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 214,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 215,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 216,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 217,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 218,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 219,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 220,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 221,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 222,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 223,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 224,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 225,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 226,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 227,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 228,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 229,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 230,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 231,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 232,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 233,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 234,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 235,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 236,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 237,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 238,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 239,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 240,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 241,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 242,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 243,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 244,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 245,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 246,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 247,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 248,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 249,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 250,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 251,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 252,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 253,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 254,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 255,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 256,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 257,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 258,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 259,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 260,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 261,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 262,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 263,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 264,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 265,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 266,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 267,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 268,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 269,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 270,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 271,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 272,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 273,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 274,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 275,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 276,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 277,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 278,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 279,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 280,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 281,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 282,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 283,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 284,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 285,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 286,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 287,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 288,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 289,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 290,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 291,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 292,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 293,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 294,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 295,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 296,
                column: "Description",
                value: "Not at all");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 297,
                column: "Description",
                value: "A little bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 298,
                column: "Description",
                value: "Moderately");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 299,
                column: "Description",
                value: "Quite a bit");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 300,
                column: "Description",
                value: "Extremely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 301,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 302,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 303,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 304,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 305,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 306,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 307,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 308,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 309,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 310,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 311,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 312,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 313,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 314,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 315,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 316,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 317,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 318,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 319,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 320,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 321,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 322,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 323,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 324,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 325,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 326,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 327,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 328,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 329,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 330,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 331,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 332,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 333,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 334,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 335,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 336,
                column: "Description",
                value: "Not present");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 337,
                column: "Description",
                value: "Equivocal");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 338,
                column: "Description",
                value: "Present, but mild");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 339,
                column: "Description",
                value: "Present and moderate");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 340,
                column: "Description",
                value: "Present and severe");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 341,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 342,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 343,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 344,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 345,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 346,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 347,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 348,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 349,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 350,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 351,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 352,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 353,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 354,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 355,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 356,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 357,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 358,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 359,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 360,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 361,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 362,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 363,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 364,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 365,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 366,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 367,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 368,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 369,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 370,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 371,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 372,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 373,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 374,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 375,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 376,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 377,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 378,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 379,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 380,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 381,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 382,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 383,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 384,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 385,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 386,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 387,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 388,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 389,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 390,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 391,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 392,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 393,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 394,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 395,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 396,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 397,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 398,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 399,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 400,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 401,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 402,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 403,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 404,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 405,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 406,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 407,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 408,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 409,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 410,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 411,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 412,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 413,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 414,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 415,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 416,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 417,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 418,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 419,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 420,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 421,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 422,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 423,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 424,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 425,
                column: "Description",
                value: "Very Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 426,
                column: "Description",
                value: "Never");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 427,
                column: "Description",
                value: "Rarely");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 428,
                column: "Description",
                value: "Sometimes");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 429,
                column: "Description",
                value: "Often");

            migrationBuilder.UpdateData(
                table: "ScoringOptions",
                keyColumn: "Id",
                keyValue: 430,
                column: "Description",
                value: "Very Often");
        }
    }
}
