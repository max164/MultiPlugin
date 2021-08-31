using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Facepunch.Extend;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;
using Oxide.Game.Rust;
using Oxide.Game.Rust.Libraries;
using UnityEngine;
using Oxide.Plugins;


namespace Oxide.Plugins
{
    [Info("Multi Plugin", "Blessed", "0.0.1")]
    class MultiPlugin : RustPlugin
    {
        [ChatCommand("mynick")]
        void chatMessage(BasePlayer player)
        {
            string mylang = lang.GetLanguage(player.IPlayer.Id);
            string ip = player.IPlayer.Address;

            player.ChatMessage("Ваш никнейм: " + player.displayName);
            player.ChatMessage("Ваш язык: " + mylang);
            player.ChatMessage("Ваш IP: " + ip);
            player.ChatMessage("Ваш HP: " + player.IPlayer.Health);
        }

        [ChatCommand("heal")]
        void healMe(BasePlayer player)
        {
            player.ChatMessage("Ваш HP: " + player.IPlayer.Health);
            player.IPlayer.Heal(100);
            player.ChatMessage("Вы восстановили свое здоровье");
        }

        [ChatCommand("suicide")]
        void suicide(BasePlayer player)
        {
            player.Hurt(99);
            player.ChatMessage("Вы самоубились");
        }
    }
}