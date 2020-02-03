using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandLog : MonoBehaviour
{
    public static Queue<Command> commands = new Queue<Command>();
}
