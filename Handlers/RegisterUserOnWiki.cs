﻿using System;
using System.Threading.Tasks;
using CommandsAndHandlers.Commands;

namespace CommandsAndHandlers.Handlers
{
    public class RegisterUserOnWiki : ICommandHandlerAsync<RegisterUserCommand>
    {
        public Task HandleAsync(RegisterUserCommand command)
        {
            Console.WriteLine($"{command.UserFirstName} {command.UserLastName} registered on the Wiki!");

            return Task.CompletedTask;
        }
    }
}