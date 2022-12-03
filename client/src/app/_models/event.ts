import { User } from './user';

export interface GameEvent
{
    id: number;
    idPin: number;
    participants: User[];
    maxPlayers: number;
}