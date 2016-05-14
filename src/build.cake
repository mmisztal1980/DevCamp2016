/**
    File: build.cake
    Description : BowlingGame BuildSystem
    Author: yci@kmd.dk
 */
 
var target = Argument("target", "UnitTests");
var configuration = Argument("configuration", "Debug");

var buildDir = "./Build";
var solutionFile = "./BowlingGame.sln";

// Clean the buildDir
Task("Clean").Does(() => {
        
}); // Clean

// Build the project
Task("Build")
    .IsDependentOn("Clean")
    .Does(() => {
     DotNetBuild(solutionFile, c => c.Configuration = configuration);        
}); // Build

Task("UnitTests")
    .IsDependentOn("Build")
    .Does(() => {
    XUnit2(string.Format("**/bin/{0}/*.UnitTests.dll", configuration));
}); // UnitTests

Task("IntegrationTests")
    .Does(() => {
    Information("Integration Tests !!! ");
    XUnit2(string.Format("**/bin/{0}/*.IntegrationTests.dll", configuration));
});

RunTarget(target);