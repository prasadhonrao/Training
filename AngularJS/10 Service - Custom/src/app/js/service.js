(function(){

	var gitHub = function($http){

		var getUser = function(username){
			return $http.get("https://api.github.com/users/" + username)
					    .then(function (response){
					     	return response.data;
					     });
		};

		var getRepos = function(user){
			return $http.get(user.repos_url)
				   		.then(function(response){
				   			return response.data;	
				   		});
		};

		return {
			getUser : getUser,
			getRepos : getRepos
		};
	};

	var module = angular.module("GitHubViewer");
	module.factory("gitHub", gitHub);

}());	