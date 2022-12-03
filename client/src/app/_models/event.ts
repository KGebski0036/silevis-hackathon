import { Pitch } from './pitch';
import { User } from './user';

export interface GameEvent
{
    id?: number,
    participants?: User[],
    maxPlayers?: number,
    dateFrom?: Date,
    dateTo?: Date,
    pitchId?: number,
    pitch?: Pitch,
    description?: string,
}