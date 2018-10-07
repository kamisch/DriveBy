using TestGooglePlaces.Places;
private async void TestGooglePlaces()
        {
            Response results;
            var placeList = new List<Place>();
            string apiKey = "AIzaSyATq2dQjlXA0W7WLPyPdELSQUXOthD55vk";

            if ((string.IsNullOrEmpty(txtLat.Text) || string.IsNullOrEmpty(txtLon.Text))) //if we dont have a lon/lat .. search txt
            {
                results = await Places.Api.TextSearch(txtQuery.Text, apiKey);
            }
            else
            {
                results = await Places.Api.SearchPlaces(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLon.Text), txtQuery.Text, apiKey);
            }

            //add the results to placeList
            foreach (var place in results.Places)
            {
                placeList.Add(place);
            }

            //if there are more than one 'page' of results...
            while (results.Next != null)
            {
                //get the next lot of results
                results = await Places.Api.GetNext(results.Next, apiKey);

                foreach (var place in results.Places)
                {
                    placeList.Add(place);
                }
            }

            foreach (var place in placeList)
            {
                var placeDetails = await Places.Api.GetDetails(place.PlaceId, apiKey);

                //do stuff with your place and placeDetails                
                string name = place.Name;
                string address = placeDetails.Address;
                //......
            }

        }