
namespace Mind_Map.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<UserChatBotHistory> UserChatBotHistories { get; set; }
        public DbSet<PersonalityTrait> PersonalityTraits { get; set; }
        public DbSet<PersonalityTestAns> PersonalityTestAnswers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<ScoringOption> ScoringOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Ensure all string properties use nvarchar for Unicode support
            modelBuilder.Entity<UserChatBotHistory>()
                .Property(e => e.UserMessage)
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<UserChatBotHistory>()
                .Property(e => e.BotResponse)
                .HasColumnType("nvarchar(max)");

            base.OnModelCreating(modelBuilder);
        
        // Relationships
        modelBuilder.Entity<Assessment>()
                .HasOne(a => a.User)
                .WithMany(u => u.Assessments)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.Domain)
                .WithMany()
                .HasForeignKey(a => a.DomainId);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Assessment)
                .WithMany(a => a.Answers)
                .HasForeignKey(a => a.AssessmentId);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany()
                .HasForeignKey(a => a.QuestionId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Domain)
                .WithMany(d => d.Questions)
                .HasForeignKey(q => q.DomainId);

            modelBuilder.Entity<ScoringOption>()
                .HasOne(so => so.Question)
                .WithMany(q => q.ScoringOptions)
                .HasForeignKey(so => so.QuestionId);

            // Seed Domains (Level 1 and Level 2)
            modelBuilder.Entity<Domain>().HasData(

        // Level 1 Domains (existing)
        new Domain { Id = 1, Name = "Depression", PotentialDisorder = "اضطرابات الاكتئاب", Threshold = 2, Recommendation = "تشير إجاباتك إلى احتمال وجود اكتئاب. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - الاكتئاب - النموذج المختصر واستشارة أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 2, Name = "Anger", PotentialDisorder = "مشاكل متعلقة بالغضب", Threshold = 2, Recommendation = "تشير إجاباتك إلى وجود مشاكل محتملة في الغضب. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - الغضب - النموذج المختصر واستشارة أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 3, Name = "Mania", PotentialDisorder = "اضطراب ثنائي القطب أو نوبات الهوس", Threshold = 2, Recommendation = "تشير إجاباتك إلى احتمال وجود أعراض هوسية. يُنصح باستخدام مقياس التقييم الذاتي لهوس ألتمن واستشارة أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 4, Name = "Anxiety", PotentialDisorder = "اضطرابات القلق", Threshold = 2, Recommendation = "تشير إجاباتك إلى احتمال وجود قلق. يُنصح بالنظر في نموذج PROMIS للضيق العاطفي - القلق - النموذج المختصر واستشارة أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 5, Name = "Somatic Symptoms", PotentialDisorder = "اضطرابات الأعراض الجسدية", Threshold = 2, Recommendation = "تشير إجاباتك إلى أعراض جسدية قد تكون مرتبطة بالتوتر. يُنصح باستخدام استبيان صحة المريض 15 (PHQ-15) واستشارة أخصائي طبي.", Level = "Level 1" },
        new Domain { Id = 6, Name = "Suicidal Ideation", PotentialDisorder = "أفكار انتحارية", Threshold = 1, Recommendation = "عاجل: تشير إجاباتك إلى أفكار إيذاء النفس. يرجى الاتصال بأخصائي صحة نفسية أو خط الأزمة فوراً.", Level = "Level 1" },
        new Domain { Id = 7, Name = "Psychosis", PotentialDisorder = "اضطرابات ذهانية", Threshold = 1, Recommendation = "عاجل: تشير إجاباتك إلى أعراض ذهانية محتملة. يرجى استشارة أخصائي صحة نفسية فوراً.", Level = "Level 1" },
        new Domain { Id = 8, Name = "Sleep Problems", PotentialDisorder = "اضطرابات النوم", Threshold = 2, Recommendation = "تشير إجاباتك إلى صعوبات في النوم. يُنصح بالنظر في نموذج PROMIS للاضطرابات النوم - النموذج المختصر واستشارة أخصائي نوم أو أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 9, Name = "Memory", PotentialDisorder = "ضعف إدراكي", Threshold = 2, Recommendation = "تشير إجاباتك إلى مشاكل في الذاكرة. يُنصح باستشارة طبيب أعصاب أو أخصائي صحة نفسية لإجراء تقييم إدراكي.", Level = "Level 1" },
        new Domain { Id = 10, Name = "Repetitive Thoughts and Behaviors", PotentialDisorder = "اضطراب الوسواس القهري (OCD)", Threshold = 2, Recommendation = "تشير إجاباتك إلى احتمال وجود اضطراب الوسواس القهري. يُنصح باستخدام مقياس شدة فلويدا للوسواس القهري (FOCI) واستشارة أخصائي صحة نفسية.", Level = "Level 1" },
        new Domain { Id = 11, Name = "Dissociation", PotentialDisorder = "اضطرابات انفصام الشخصية", Threshold = 2, Recommendation = "تشير إجاباتك إلى احتمال وجود انفصال نفسي. يُنصح باستشارة أخصائي صحة نفسية لتقييم متخصص.", Level = "Level 1" },
        new Domain { Id = 12, Name = "Personality Functioning", PotentialDisorder = "اضطرابات الشخصية", Threshold = 2, Recommendation = "تشير إجاباتك إلى تحديات في الهوية أو العلاقات. يُنصح باستشارة أخصائي صحة نفسية لتقييم الشخصية.", Level = "Level 1" },
        new Domain { Id = 13, Name = "Substance Use", PotentialDisorder = "اضطرابات تعاطي المواد", Threshold = 1, Recommendation = "تشير إجاباتك إلى احتمال سوء استخدام المواد. يُنصح باستخدام ASSIST المعدل من NIDA واستشارة أخصائي تعاطي المخدرات.", Level = "Level 1" },
        // Level 2 Domains (new)
        new Domain { Id = 14, Name = "Anxiety", PotentialDisorder = "اضطرابات القلق", Threshold = 60, Recommendation = "تشير إجاباتك إلى أعراض قلق كبيرة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم.", Level = "Level 2" }, // T-score ≥ 60 (Moderate)
        new Domain { Id = 15, Name = "Mania", PotentialDisorder = "اضطراب ثنائي القطب أو نوبات الهوس", Threshold = 6, Recommendation = "تشير إجاباتك إلى احتمال عالي لأعراض الهوس. يُنصح باستشارة أخصائي صحة نفسية فوراً.", Level = "Level 2" }, // Score ≥ 6
        new Domain { Id = 16, Name = "Repetitive Thoughts and Behaviors", PotentialDisorder = "اضطراب الوسواس القهري (OCD)", Threshold = 8, Recommendation = "تشير إجاباتك إلى أعراض وسواس قهري كبيرة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم.", Level = "Level 2" }, // Score ≥ 8
        new Domain { Id = 17, Name = "PTSD", PotentialDisorder = "اضطراب ما بعد الصدمة", Threshold = 33, Recommendation = "تشير إجاباتك إلى أعراض كبيرة لاضطراب ما بعد الصدمة. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم.", Level = "Level 2" }, // Score ≥ 33 (suggested cutoff)
        new Domain { Id = 18, Name = "Psychosis", PotentialDisorder = "اضطرابات ذهانية", Threshold = 2, Recommendation = "تشير إجاباتك إلى أعراض ذهانية محتملة. يُنصح باستشارة أخصائي صحة نفسية فوراً.", Level = "Level 2" }, // Score ≥ 2 (mild or greater)
        new Domain { Id = 19, Name = "ADHD", PotentialDisorder = "اضطراب نقص الانتباه مع فرط النشاط", Threshold = 4, Recommendation = "تشير إجاباتك إلى أعراض محتملة لاضطراب نقص الانتباه مع فرط النشاط. يُنصح باستشارة أخصائي صحة نفسية لمزيد من التقييم.", Level = "Level 2" } // 4+ shaded boxes in Part A
    );



            // Seed Questions (Level 1 and Level 2)
            int questionId = 1;
            int scoringOptionId = 1;


            // Level 1 Questions (existing) translated into Arabic
            modelBuilder.Entity<Question>().HasData(
                new Question { Id = questionId++, Text = "قلة الاهتمام أو المتعة في القيام بالأشياء؟", DomainId = 1 },
                new Question { Id = questionId++, Text = "الشعور بالحزن أو الاكتئاب أو اليأس؟", DomainId = 1 },
                new Question { Id = questionId++, Text = "الشعور بمزيد من التهيج أو الغضب أكثر من المعتاد؟", DomainId = 2 },
                new Question { Id = questionId++, Text = "النوم أقل من المعتاد، ولكن لا تزال تملك الكثير من الطاقة؟", DomainId = 3 },
                new Question { Id = questionId++, Text = "بدء المزيد من المشاريع من المعتاد أو القيام بأشياء أكثر خطورة من المعتاد؟", DomainId = 3 },
                new Question { Id = questionId++, Text = "الشعور بالتوتر أو القلق أو الخوف أو القلق أو التوتر؟", DomainId = 4 },
                new Question { Id = questionId++, Text = "الشعور بنوبات هلع أو الخوف؟", DomainId = 4 },
                new Question { Id = questionId++, Text = "تجنب المواقف التي تجعلك تشعر بالقلق؟", DomainId = 4 },
                new Question { Id = questionId++, Text = "آلام وأوجاع غير مفسرة (مثل الرأس، الظهر، المفاصل، البطن، الساقين)؟", DomainId = 5 },
                new Question { Id = questionId++, Text = "الشعور بأن أمراضك لا تؤخذ على محمل الجد بما فيه الكفاية؟", DomainId = 5 },
                new Question { Id = questionId++, Text = "أفكار عن إيذاء نفسك؟", DomainId = 6 },
                new Question { Id = questionId++, Text = "سماع أشياء لا يستطيع الآخرون سماعها، مثل الأصوات حتى عندما لا يكون هناك أحد؟", DomainId = 7 },
                new Question { Id = questionId++, Text = "الشعور بأن شخصاً ما يمكنه سماع أفكارك، أو أنك تستطيع سماع ما يفكر به شخص آخر؟", DomainId = 7 },
                new Question { Id = questionId++, Text = "مشاكل في النوم أثرت على جودة نومك بشكل عام؟", DomainId = 8 },
                new Question { Id = questionId++, Text = "مشاكل في الذاكرة (مثل تعلم معلومات جديدة) أو في المكان (مثل إيجاد طريقك إلى المنزل)؟", DomainId = 9 },
                new Question { Id = questionId++, Text = "أفكار أو رغبات أو صور غير سارة تدخل ذهنك مرارًا وتكرارًا؟", DomainId = 10 },
                new Question { Id = questionId++, Text = "الشعور بأنك مدفوع لأداء سلوكيات أو أعمال ذهنية معينة مرارًا وتكرارًا؟", DomainId = 10 },
                new Question { Id = questionId++, Text = "الشعور بالانفصال أو البعد عن نفسك، جسدك، محيطك المادي، أو ذكرياتك؟", DomainId = 11 },
                new Question { Id = questionId++, Text = "عدم معرفة من أنت حقًا أو ما تريد من الحياة؟", DomainId = 12 },
                new Question { Id = questionId++, Text = "عدم الشعور بالقرب من الآخرين أو الاستمتاع بعلاقاتك معهم؟", DomainId = 12 },
                new Question { Id = questionId++, Text = "شرب 4 مشروبات كحولية على الأقل في يوم واحد؟", DomainId = 13 },
                new Question { Id = questionId++, Text = "تدخين أي سجائر أو سيجار أو غليون، أو استخدام السعوط أو مضغ التبغ؟", DomainId = 13 },
                new Question { Id = questionId++, Text = "استخدام أي من الأدوية التالية بمفردك، أي بدون وصفة طبية، بجرعات أكبر أو لفترة أطول من الموصوفة [مثل مسكنات الألم (مثل فيكودين)، المنشطات (مثل ريتالين أو أدرال)، المهدئات أو المهدئات (مثل حبوب النوم أو فاليم)، أو المخدرات مثل الماريجوانا، الكوكايين أو الكراك، مخدرات النوادي (مثل الإكستاسي)، الهلوسة (مثل LSD)، الهيروين، الاستنشاق أو المذيبات (مثل الغراء)، أو الميثامفيتامين (مثل السريع)]؟", DomainId = 13 }
            );


            // Scoring Options for Level 1 Questions
            var level1ScoringOptions = new[]
            {

                    new { Score = 0, Description = "لا شيء / لا على الإطلاق" },
                    new { Score = 1, Description = "طفيف / نادر، أقل من يوم أو يومين" },
                    new { Score = 2, Description = "خفيف / عدة أيام" },
                    new { Score = 3, Description = "متوسط / أكثر من نصف الأيام" },
                    new { Score = 4, Description = "شديد / تقريباً كل يوم" }
            };

            for (int i = 1; i <= 23; i++)
            {
                foreach (var option in level1ScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = i, Score = option.Score, Description = option.Description }
                    );
                }
            }

            // Level 2 Anxiety Questions
            var anxietyQuestions = new[]
                   {
                    "شعرت بالخوف.",
                    "شعرت بالقلق.",
                    "شعرت بالهم.",
                    "وجدت صعوبة في التركيز على أي شيء غير قلقي.",
                    "شعرت بالتوتر.",
                    "شعرت بعدم الارتياح.",
                    "شعرت بالتوتر الشديد."
                };
            var anxietyScoringOptions = new[]
{
                    new { Score = 1, Description = "أبداً" },
                    new { Score = 2, Description = "نادراً" },
                    new { Score = 3, Description = "أحياناً" },
                    new { Score = 4, Description = "غالباً" },
                    new { Score = 5, Description = "دائماً" }
                };
            foreach (var question in anxietyQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 14 }
                );
                foreach (var option in anxietyScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }

            // Level 2 Mania Questions

            var maniaQuestions = new[]
                        {
                "الشعور بسعادة أو بهجة أكثر من المعتاد.",
                "الشعور بثقة بالنفس أكثر من المعتاد.",
                "الحاجة إلى نوم أقل من المعتاد.",
                "التحدث أكثر من المعتاد.",
                "أن تكون أكثر نشاطاً (اجتماعياً، جنسياً، في العمل، المنزل، أو المدرسة) من المعتاد."
            };
            var maniaScoringOptions = new[]
            {
                new { Score = 0, Description = "لا على الإطلاق" },
                new { Score = 1, Description = "أحياناً" },
                new { Score = 2, Description = "غالباً" },
                new { Score = 3, Description = "كثيراً" },
                new { Score = 4, Description = "طوال الوقت" }
            };
            foreach (var question in maniaQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 15 }
                );
                foreach (var option in maniaScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }

            // Level 2 OCD Questions

            var ocdQuestions = new[]
                            {
                    "كم من الوقت يشغلك في المتوسط هذه الأفكار أو السلوكيات يومياً؟",
                    "ما مدى الضيق الذي تسببه لك هذه الأفكار أو السلوكيات؟",
                    "ما مدى صعوبة التحكم في هذه الأفكار أو السلوكيات؟",
                    "ما مدى تسبب هذه الأفكار أو السلوكيات في تجنبك القيام بأي شيء، أو الذهاب إلى أي مكان، أو التواجد مع أي شخص؟",
                    "ما مدى تأثير هذه الأفكار أو السلوكيات على دراستك أو عملك أو حياتك الاجتماعية أو العائلية؟"
                };
            var ocdScoringOptions = new[]
            {
                    new { Score = 0, Description = "لا شيء" },
                    new { Score = 1, Description = "خفيف" },
                    new { Score = 2, Description = "متوسط" },
                    new { Score = 3, Description = "شديد" },
                    new { Score = 4, Description = "شديد جداً" }
                };
            foreach (var question in ocdQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 16 }
                );
                foreach (var option in ocdScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }

            // Level 2 PTSD Questions

            var ptsdQuestions = new[]
                            {
                    "ذكريات متكررة ومزعجة وغير مرغوب فيها للتجربة المجهدة؟",
                    "أحلام متكررة ومزعجة عن التجربة المجهدة؟",
                    "الشعور فجأة أو التصرف كما لو أن التجربة المجهدة تحدث مرة أخرى (كما لو كنت تعيشها فعلاً مرة أخرى)؟",
                    "الشعور بالانزعاج الشديد عندما يذكرك شيء بالتجربة المجهدة؟",
                    "وجود ردود فعل جسدية قوية عندما يذكرك شيء بالتجربة المجهدة (مثل خفقان القلب، صعوبة في التنفس، التعرق)؟",
                    "تجنب الذكريات أو الأفكار أو المشاعر المتعلقة بالتجربة المجهدة؟",
                    "تجنب المثيرات الخارجية التي تذكرك بالتجربة المجهدة (مثل الأشخاص، الأماكن، المحادثات، الأنشطة، الأشياء، أو المواقف)؟",
                    "صعوبة في تذكر أجزاء مهمة من التجربة المجهدة؟",
                    "وجود معتقدات سلبية قوية عن نفسك أو الآخرين أو العالم (مثل أفكار: أنا سيء، هناك شيء خطير خاطئ بي، لا يمكن الوثوق بأحد، العالم خطير تماماً)؟",
                    "لوم نفسك أو شخص آخر على التجربة المجهدة أو ما حدث بعدها؟",
                    "وجود مشاعر سلبية قوية مثل الخوف، الرعب، الغضب، الذنب، أو الخجل؟",
                    "فقدان الاهتمام بالأنشطة التي كنت تستمتع بها؟",
                    "الشعور بالبعد أو الانفصال عن الآخرين؟",
                    "صعوبة في تجربة المشاعر الإيجابية (مثل عدم القدرة على الشعور بالسعادة أو الحب تجاه الأشخاص المقربين)؟",
                    "سلوك سريع الغضب، نوبات غضب، أو التصرف بعدوانية؟",
                    "المخاطرة المفرطة أو القيام بأشياء قد تسبب لك الأذى؟",
                    "كونك 'متيقظاً جداً' أو مراقباً أو في حالة حذر؟",
                    "الشعور بالتوتر أو القفز بسهولة؟",
                    "صعوبة في التركيز؟",
                    "صعوبة في النوم أو البقاء نائماً؟"
                };
            var ptsdScoringOptions = new[]
            {
                    new { Score = 0, Description = "لا على الإطلاق" },
                    new { Score = 1, Description = "قليلاً" },
                    new { Score = 2, Description = "بشكل معتدل" },
                    new { Score = 3, Description = "إلى حد كبير" },
                    new { Score = 4, Description = "بشكل شديد" }
                };
            foreach (var question in ptsdQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 17 }
                );
                foreach (var option in ptsdScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }

            // Level 2 Psychosis Questions

            var psychosisQuestions = new[]
                            {
                    "الهلاوس",
                    "الأوهام",
                    "الكلام غير المنظم",
                    "السلوك النفسي الحركي الشاذ",
                    "الأعراض السلبية (تعبير عاطفي محدود أو انعدام الدافع)",
                    "الاضطراب المعرفي",
                    "الاكتئاب",
                    "الجنون"
                };

            var psychosisScoringOptions = new[]
            {
                    new { Score = 0, Description = "غير موجود" },
                    new { Score = 1, Description = "غير واضح" },
                    new { Score = 2, Description = "موجود، ولكن خفيف" },
                    new { Score = 3, Description = "موجود ومعتدل" },
                    new { Score = 4, Description = "موجود وشديد" }
                };
            foreach (var question in psychosisQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 18 }
                );
                foreach (var option in psychosisScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }

            // Level 2 ADHD Questions

            var adhdQuestions = new[]
             {
                "كم مرة تواجه صعوبة في إنهاء التفاصيل النهائية لمشروع، بعد أن يتم إنجاز الأجزاء الصعبة؟",
                "كم مرة تواجه صعوبة في ترتيب الأشياء عندما يتعين عليك أداء مهمة تتطلب التنظيم؟",
                "كم مرة تواجه صعوبة في تذكر المواعيد أو الالتزامات؟",
                "عندما يكون لديك مهمة تتطلب الكثير من التفكير، كم مرة تتجنب أو تؤجل البدء بها؟",
                "كم مرة تتحرك أو تزعج يديك أو قدميك عندما يتعين عليك الجلوس لفترة طويلة؟",
                "كم مرة تشعر بالنشاط المفرط وترغب في القيام بالأشياء، وكأنك مدفوع بمحرك؟",
                "كم مرة ترتكب أخطاء غير مبالية عندما يتعين عليك العمل على مشروع ممل أو صعب؟",
                "كم مرة تجد صعوبة في الحفاظ على انتباهك عندما تقوم بعمل ممل أو متكرر؟",
                "كم مرة تجد صعوبة في التركيز على ما يقوله الناس لك، حتى عندما يتحدثون إليك مباشرة؟",
                "كم مرة تضع أو تجد صعوبة في العثور على الأشياء في المنزل أو في العمل؟",
                "كم مرة يتم تشتيتك بسبب النشاط أو الضوضاء من حولك؟",
                "كم مرة تغادر مقعدك في الاجتماعات أو في المواقف التي يُتوقع منك البقاء جالسًا فيها؟",
                "كم مرة تشعر بالقلق أو التململ؟",
                "كم مرة تجد صعوبة في الاسترخاء عندما يكون لديك وقت لنفسك؟",
                "كم مرة تجد نفسك تتحدث كثيرًا عندما تكون في مواقف اجتماعية؟",
                "عندما تكون في محادثة، كم مرة تجد نفسك تكمل جمل الأشخاص الذين تتحدث معهم قبل أن يتمكنوا من إتمامها بأنفسهم؟",
                "كم مرة تجد صعوبة في الانتظار لدورك في المواقف التي يتطلب فيها أخذ الدور؟",
                "كم مرة تقاطع الآخرين عندما يكونون مشغولين؟"
            };
            var adhdScoringOptions = new[]
            {

                new { Score = 0, Description = "أبدًا" },
                new { Score = 1, Description =  "نادراً"},
                new { Score = 2, Description = " أحياناً"},
                new { Score = 3, Description = " غالباً"},
                new { Score = 4, Description = "كثيراً جداً"}
            };
            foreach (var question in adhdQuestions)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question { Id = questionId, Text = question, DomainId = 19 }
                );
                foreach (var option in adhdScoringOptions)
                {
                    modelBuilder.Entity<ScoringOption>().HasData(
                        new ScoringOption { Id = scoringOptionId++, QuestionId = questionId, Score = option.Score, Description = option.Description }
                    );
                }
                questionId++;
            }


            // Optional: Seed initial personality traits


            modelBuilder.Entity<PersonalityTrait>().HasData(
    new PersonalityTrait { Id = 1, Name = "الانفتاح", Description = "تصف الميل إلى الاجتماعي مقابل التحفظ" },
    new PersonalityTrait { Id = 2, Name = "الحدس", Description = "التركيز على الأنماط مقابل الحقائق" },
    new PersonalityTrait { Id = 3, Name = "التفكير", Description = "المنطق مقابل التعاطف" },
    new PersonalityTrait { Id = 4, Name = "الحكم", Description = "التفضيل نحو النظام مقابل العفوية" },
    new PersonalityTrait { Id = 5, Name = "الحزم", Description = "الثقة بالنفس مقابل الحساسية" });


            //            modelBuilder.Entity<PersonalityTrait>().HasData(
            //           new PersonalityTrait { Id = 1, Name = "Extraversion", Description = "Describes sociability vs. reservedness" },
            //new PersonalityTrait { Id = 2, Name = "Intuition", Description = "Focus on patterns vs. facts" },
            //new PersonalityTrait { Id = 3, Name = "Thinking", Description = "Logic vs. empathy" },
            //new PersonalityTrait { Id = 4, Name = "Judging", Description = "Preference for order vs. spontaneity" },
            //new PersonalityTrait { Id = 5, Name = "Assertiveness", Description = "Self-assurance vs. sensitivity" });



        }
    }
}
