using easyar;
using UnityEngine;
using UnityEngine.Events;

public class ImageTrakingController : MonoBehaviour
{
    [SerializeField] public ImageTargetController targetController;
    [SerializeField] private UnityEvent onTrackedEvent;
    [SerializeField] private UnityEvent onLostEvent;

    private void Start()
    {
        AddTargetControllerEvents(targetController);
    }
    private void AddTargetControllerEvents(ImageTargetController controller)
    {
        if (!controller)
        {
            return;
        }

        controller.TargetFound += () =>
        {
            onTrackedEvent.Invoke();
        };
        controller.TargetLost += () =>
        {
            onLostEvent.Invoke();
        };
    }
}
