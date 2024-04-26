﻿using System;
using System.Collections.Generic;

namespace PokemonTeamBuilder.API;

public partial class PokemonTeam
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TrainerId { get; set; }

    public virtual Trainer Trainer { get; set; } = null!;
}