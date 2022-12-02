import { User } from './user';

export interface Event
{
    id: number;
    idPin: number;
    participants: User[];
    maxPlayers: number;
}