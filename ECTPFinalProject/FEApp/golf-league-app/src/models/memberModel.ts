export interface Member{
memberId: number,
firstName?: string,
lastName?: string,
handicap: number,
leagueId: number,
league?: League,
scores?: Score[]
}

export interface League{
leagueId: number,
name?: string,
golfCourseId: number,
golfCourse?: GolfCourse,
members?: Member[]
}

export interface Score{
scoreId: number,
weekNumber: number,
hole1Score: number,
hole2Score: number,
hole3Score: number,
hole4Score: number,
hole5Score: number,
hole6Score: number,
hole7Score: number,
hole8Score: number,
hole9Score: number,
memberId: number,
member?: Member
}

export interface GolfCourse{
leagueId: number,
name: string,
golfCourseId: number,
golfCourse?: GolfCourse,
members: Member[]
}

export interface Hole{
holeId: number,
golfCourseId: number,
golfCourse?: GolfCourse,
holeNumber: number,
par: number
 }