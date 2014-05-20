/*global require:false*/
require.config({
	baseUrl: "",
	paths: {
		manager:           "/scripts/manager",
		appStartGenerated: "cache/appStartGenerated",
		pluginManager:     "/scripts/pluginManager",
		accountManager:    "/scripts/accountManager",
		constants:         "/home/constants?noext",
		generator:         "/scripts/generator",
		io:                "/scripts/io",
		utils:             "/scripts/utils",
		moment:            "/scripts/libs/moment.min",
		lang:              "/home/languages?noext",
		queue:             "/scripts/queue",
		pageInit:          "/scripts/pageInit",
		tablesorter:       "/scripts/libs/jquery.tablesorter.widgets.min"
	},
	shim: {
		"tablesorter": {
			deps: ['/scripts/libs/jquery.tablesorter.min.js']
		}
	},
	waitSeconds: 60
});
