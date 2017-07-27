
        // Add these to Part 2
        private Player player;
        private float speed;

	public override void AI()
        {
            // Targeting the Player
            Target(); // Sets the target to be the player
            // Handles Despawning
            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if (!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, 10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
            // Moving towards the target
            Move(new Vector2(0, -150f));
            // Charging 
            npc.ai[1] -= 1f; // This will decrease the ai of 1. I use 0 for movement ai and 1 for attacking ai
            if(npc.ai[1] <= 0f) // If the AI value is less than or equal to one, we want the NPC to attack. In this case, he will shoot a projectile at the player.
            {
                Shoot(); // Calls the Shoot Function
            }
        }

        private void Target()
        {
            player = Main.player[npc.target];
        }

        private void Move(Vector2 offset)
        {
            float speed = 5f;
            Vector2 moveTo = player.Center + offset;
            Vector2 move = moveTo - npc.Center;
            float magnitude = (float)Math.Sqrt(move.X * move.X + move.Y * move.Y);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            float turnResistance = 10f; //the larger this is, the slower the npc will turn
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = (float)Math.Sqrt(move.X * move.X + move.Y * move.Y);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }
        

        private void Shoot()
        {
            int type = mod.ProjectileType("TutorialBossProjectile"); // Sets the type of the projectile
            Vector2 velocity = player.Center - npc.Center; // Gets the distance between npc and target
            float magnitude = (float)Math.Sqrt(velocity.X * velocity.X + velocity.Y * velocity.Y); // Gets the square route of the velocity
            if(magnitude > 0)
            {
                velocity *= 5f / magnitude; // Multiplies the velocity by 5 / mag
            } else
            {
                velocity = new Vector2(0f, 5f); // Sets velocity to max
            }
            Projectile.NewProjectile(npc.Center, velocity, type, npc.damage, 2f); // Spawns the projectile
            npc.ai[1] = 200f; // Resets the time
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 1; // Increases the frame counter by 1
            npc.frameCounter %= 10; // Makes it so after 10 ticks the animation resets to the beginning.
            int frame = (int)(npc.frameCounter / 2.0); // Chooses the animation frame. 
            if (frame >= Main.npcFrameCount[npc.type]) frame = 0; // Makes sure the frame doesn't go over the max number.
            npc.frame.Y = frame * frameHeight; // Sets the frame then multiplies by height. Example 1 * 33 will be the second frame in our animation.
            RotateNPCToTarget(); // Rotates the NPC to face the player.
        }

        private void RotateNPCToTarget()
        {
            if (player == null) return; // Returns if no target.

            Vector2 direction = npc.Center - player.Center; // Gets the distance between npc and target
            float rotation = (float)Math.Atan2(direction.Y, direction.X); // Gets the angle from direction
            npc.rotation = rotation + ((float)Math.PI * 0.5f); // Rotates the sprite by the rotation value  then adding PI.
        }
