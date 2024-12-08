using System;
using System.Collections.Generic;

public class ActionNotifier
{
    private List<IActionObserver> observers = new List<IActionObserver>();

    // ע��۲���
    public void AddObserver(IActionObserver observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    // �Ƴ��۲���
    public void RemoveObserver(IActionObserver observer)
    {
        observers.Remove(observer);
    }

    // ֪ͨ���й۲��߶������
    public void NotifyAnimationCompleted(string actionName)
    {
        foreach (var observer in observers)
        {
            observer.OnAnimationCompleted(actionName);
        }
    }

    // ֪ͨ���й۲�����Ч���
    public void NotifySoundEffectCompleted(string actionName)
    {
        foreach (var observer in observers)
        {
            observer.OnSoundEffectCompleted(actionName);
        }
    }
}
