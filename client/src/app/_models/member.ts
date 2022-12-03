import { Photo } from "./photo";

export interface Member{
    id: number;
    userName: string;
    photoUrl: string;
    age: number;
    nickname: string;
    created: Date;
    photos: Photo[];
    gender: string;
    country: string;

}