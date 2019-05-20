module TonalTheory

type PitchBase = 
    | C
    | D
    | E
    | F
    | G
    | A
    | B

type PitchAccident =
    | DoubleFlat  = -2
    | Flat        = -1
    | Natural     =  0
    | Sharp       = +1
    | DoubleSharp = +2

type Octave = byte
type PitchClass = PitchBase * PitchAccident
type Pitch = PitchClass * Octave

type IntervalNumber = 
    | Unison  = 1
    | Second  = 2
    | Third   = 3
    | Fourth  = 4
    | Fifth   = 5
    | Seventh = 6
    | Octave  = 7

type IntervalQuality = 
    | Perfect
    | Major 
    | Minor
    | Augmented
    | Diminished

type IntervalDirection = 
    | Ascending
    | Descending

type Interval = IntervalNumber * IntervalDirection