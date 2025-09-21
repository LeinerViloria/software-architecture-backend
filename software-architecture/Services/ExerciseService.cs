
using Grpc.Core;

namespace software_architecture.Services;

public class ExerciseService(ILogger<ExerciseService> logger) : Exercise.ExerciseBase
{
    public override Task<ExerciseResponse> GetExercise(GetExerciseRequest request, ServerCallContext context)
    {
        logger.LogInformation("The message is received to look for {Name}", request.Id);
        return base.GetExercise(request, context);
    }
}