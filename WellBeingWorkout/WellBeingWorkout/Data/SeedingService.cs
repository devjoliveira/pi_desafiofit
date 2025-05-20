using WellBeingWorkout.Models.Enuns;

namespace WellBeingWorkout.Data
{
    public static class SeedingService
    {
        public static async Task SeedAsync(WellBeingWorkoutContext context)
        {


            if (context.Challenge.Any())
                return;
                

            var challenges = new List<Challenge>
            {
                // EASY
                new Challenge { Name = "Beber 2 copos de água", Description = "Beba ao menos 2 copos de água ao longo do dia.", TotalXp = 10, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Respiração consciente", Description = "Faça 3 minutos de respiração profunda e consciente.", TotalXp = 12, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Caminhada curta", Description = "Caminhe por 10 minutos em ritmo leve.", TotalXp = 15, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Alongamento matinal", Description = "Faça 5 minutos de alongamento após acordar.", TotalXp = 10, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Postura correta", Description = "Mantenha a postura correta enquanto estiver sentado por pelo menos 1 hora.", TotalXp = 10, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Meditação rápida", Description = "Medite por 5 minutos em um local tranquilo.", TotalXp = 12, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Evitar refrigerantes", Description = "Passe o dia sem consumir refrigerantes ou bebidas açucaradas.", TotalXp = 13, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Fruta no café", Description = "Inclua uma fruta natural no café da manhã.", TotalXp = 10, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Pausa ativa", Description = "Faça uma pausa ativa com leve alongamento a cada 2 horas.", TotalXp = 11, ChallengeLevel = ChallengeLevel.EASY },
                new Challenge { Name = "Caminhar após almoço", Description = "Caminhe por 5 minutos após o almoço para ajudar na digestão.", TotalXp = 12, ChallengeLevel = ChallengeLevel.EASY },

                // MID
                new Challenge { Name = "Beber 2L de água", Description = "Beba pelo menos 2 litros de água ao longo do dia.", TotalXp = 20, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Caminhada moderada", Description = "Caminhe por 30 minutos em ritmo moderado.", TotalXp = 25, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Exercício físico leve", Description = "Faça 15 minutos de exercícios físicos (agachamento, polichinelo, etc).", TotalXp = 22, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Evitar doces", Description = "Fique o dia todo sem consumir doces.", TotalXp = 23, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Meditação guiada", Description = "Faça uma sessão de meditação guiada de 15 minutos.", TotalXp = 24, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Subir escadas", Description = "Evite o elevador e use escadas ao menos 3 vezes no dia.", TotalXp = 22, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Almoço saudável", Description = "Tenha uma refeição com legumes, vegetais e sem frituras.", TotalXp = 20, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Treino funcional", Description = "Realize um treino funcional de 20 minutos.", TotalXp = 25, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Alongamento completo", Description = "Faça um alongamento corporal completo por 10 minutos.", TotalXp = 21, ChallengeLevel = ChallengeLevel.MID },
                new Challenge { Name = "Dormir cedo", Description = "Vá dormir antes das 22h.", TotalXp = 23, ChallengeLevel = ChallengeLevel.MID },

                // HARD
                new Challenge { Name = "Beber 3L de água", Description = "Beba ao menos 3 litros de água durante o dia.", TotalXp = 30, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Treino intenso", Description = "Faça 30 minutos de treino intenso (HIIT, corrida, etc).", TotalXp = 40, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Dia sem açúcar", Description = "Passe o dia inteiro sem consumir açúcar adicionado.", TotalXp = 35, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Caminhada longa", Description = "Caminhe por pelo menos 1 hora.", TotalXp = 32, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Jejum intermitente", Description = "Pratique um jejum intermitente de 14 a 16 horas (se estiver apto).", TotalXp = 38, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Rotina de exercícios completa", Description = "Realize uma rotina de 45 minutos envolvendo cardio, força e flexibilidade.", TotalXp = 45, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Evitar telas antes de dormir", Description = "Fique 2 horas sem usar celular ou TV antes de dormir.", TotalXp = 34, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Yoga", Description = "Faça uma prática de yoga de 30 minutos.", TotalXp = 36, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Meditação profunda", Description = "Medite por pelo menos 30 minutos.", TotalXp = 35, ChallengeLevel = ChallengeLevel.HARD },
                new Challenge { Name = "Alimentação 100% natural", Description = "Consuma apenas alimentos naturais o dia inteiro (sem industrializados).", TotalXp = 40, ChallengeLevel = ChallengeLevel.HARD },
            };

            context.Challenge.AddRange(challenges);

            context.Add(new User() { Name = "José Silva", Email = "jose@gmail.com", Level = 1, Password = "senha" });
            await context.SaveChangesAsync();
        }
    }
}
