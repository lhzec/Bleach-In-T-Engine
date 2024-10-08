using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应做普通料理消息 message
 */
public class ResCookFoodMessage : Message 
{
	//做普通料理结果[0:成功 ,1:做好的料理还没有吃或者放弃,2:请求的料理不存在,3:请求的料理不是普通料理,6:没有普通料理次数,7:魂玉不足]
	int _result;	
	//普通料理编号
	int _foodId;	
	//普通料理星级
	int _foodStar;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//做普通料理结果[0:成功 ,1:做好的料理还没有吃或者放弃,2:请求的料理不存在,3:请求的料理不是普通料理,6:没有普通料理次数,7:魂玉不足]
		SerializeUtils.WriteInt(stream, _result);
		//普通料理编号
		SerializeUtils.WriteInt(stream, _foodId);
		//普通料理星级
		SerializeUtils.WriteInt(stream, _foodStar);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//做普通料理结果[0:成功 ,1:做好的料理还没有吃或者放弃,2:请求的料理不存在,3:请求的料理不是普通料理,6:没有普通料理次数,7:魂玉不足]
		_result = SerializeUtils.ReadInt(stream);
		//普通料理编号
		_foodId = SerializeUtils.ReadInt(stream);
		//普通料理星级
		_foodStar = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 做普通料理结果[0:成功 ,1:做好的料理还没有吃或者放弃,2:请求的料理不存在,3:请求的料理不是普通料理,6:没有普通料理次数,7:魂玉不足]
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 普通料理编号
	 */
	public int FoodId
	{
		set { _foodId = value; }
	    get { return _foodId; }
	}
	
	/**
	 * 普通料理星级
	 */
	public int FoodStar
	{
		set { _foodStar = value; }
	    get { return _foodStar; }
	}
	
	
	public override int GetId() 
	{
		return 106102;
	}
}